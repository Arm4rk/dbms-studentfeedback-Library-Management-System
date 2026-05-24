const express = require("express");
const mysql = require("mysql2");
const cors = require("cors");
const crypto = require("crypto");

const app = express();

app.use(cors());
app.use(express.json());
app.use(express.urlencoded({ extended: true }));

const db = mysql.createConnection({
  host: "localhost",
  user: "root",
  password: "",
  database: "common_library_db"
});

db.connect((err) => {
  if (err) {
    console.log("Database connection failed:", err);
    return;
  }
  console.log("Connected to common_library_db");
});

// TEST ROUTES
app.get("/", (req, res) => {
  res.send("Node.js API is running");
});

app.get("/health", (req, res) => {
  res.json({
    status: "ok",
    database: "common_library_db"
  });
});

// LOGIN API
app.post("/login", (req, res) => {
  const { email, password } = req.body;

  if (!email || !password) {
    return res.json({
      success: false,
      message: "Email and password are required"
    });
  }

  const hashedPassword = crypto
    .createHash("md5")
    .update(password)
    .digest("hex");

  const sql = `
    SELECT *
    FROM lms_user
    WHERE TRIM(email) = ?
    AND password = ?
    LIMIT 1
  `;

  db.query(sql, [email.trim(), hashedPassword], (err, result) => {
    if (err) {
      return res.status(500).json({
        success: false,
        message: "Database error: " + err.sqlMessage
      });
    }

    if (result.length > 0) {
      return res.json({
        success: true,
        message: "Login successful",
        user: result[0]
      });
    }

    res.json({
      success: false,
      message: "Invalid email or password"
    });
  });
});

// ADD BOOK API
app.post("/books", (req, res) => {
  const {
    title,
    isbn,
    author,
    genre,
    description,
    publishedDate,
    quantity
  } = req.body;

  if (!title || !isbn) {
    return res.json({
      status: "error",
      message: "Book Name and ISBN are required"
    });
  }

  const sql = `
    INSERT INTO lms_books
    (
      Title,
      ISBN,
      Author,
      Genre,
      Description,
      PublishedDate,
      Quantity
    )
    VALUES (?, ?, ?, ?, ?, ?, ?)
  `;

  const values = [
    title,
    isbn,
    author || "",
    genre || "",
    description || "",
    publishedDate || null,
    quantity || 1
  ];

  db.query(sql, values, (err, result) => {
    if (err) {
      return res.status(500).json({
        status: "error",
        message: err.sqlMessage
      });
    }

    res.json({
      status: "success",
      message: "Book added successfully",
      insertedId: result.insertId
    });
  });
});

// GET BOOKS API
app.get("/books", (req, res) => {
  const sql = `
    SELECT *
    FROM lms_books
    ORDER BY BookID DESC
  `;

  db.query(sql, (err, result) => {
    if (err) {
      return res.status(500).json({
        status: "error",
        message: err.sqlMessage
      });
    }

    res.json(result);
  });
});

// ISSUE BOOK API
app.post("/issue", (req, res) => {
  const { member_id, book_id, borrower_name, issue_date, return_date } = req.body;

  if (!member_id || !book_id || !borrower_name || !issue_date || !return_date) {
    return res.json({
      status: "error",
      message: "Member ID, book, borrower name, issue date, and return date are required"
    });
  }

  const sql = `
    INSERT INTO lib_book_issue
    (
      member_id,
      ISBN,
      issue_date,
      return_date,
      status
    )
    VALUES (?, ?, ?, ?, ?)
  `;

  const values = [
    member_id,
    book_id,
    issue_date,
    return_date,
    "Issued"
  ];

  db.query(sql, values, (err, result) => {
    if (err) {
      return res.status(500).json({
        status: "error",
        message: err.sqlMessage
      });
    }

    res.json({
      status: "success",
      message: "Book issued successfully",
      insertedId: result.insertId
    });
  });
});

// VIEW ISSUED BOOKS
app.get("/issue", (req, res) => {
  const sql = `
    SELECT *
    FROM lib_book_issue
  `;

  db.query(sql, (err, result) => {
    if (err) {
      return res.status(500).json({
        status: "error",
        message: err.sqlMessage
      });
    }

    res.json(result);
  });
});

// SAVE LIBRARY FEEDBACK
app.post("/api/feedback", (req, res) => {
  const {
    year,
    sem,
    date,
    branch,
    section,
    subject,
    ques1,
    ques3,
    ques4,
    remarks
  } = req.body;

  const ques2i = req.body["ques-2i"];
  const ques2ii = req.body["ques-2ii"];
  const ques2iii = req.body["ques-2iii"];
  const ques2iv = req.body["ques-2iv"];
  const ques2v = req.body["ques-2v"];

  const sql = `
    INSERT INTO student_feedback
    (
      academic_year,
      semester,
      feedback_date,
      branch,
      section,
      subject,
      ques1,
      ques2i,
      ques2ii,
      ques2iii,
      ques2iv,
      ques2v,
      ques3,
      ques4,
      remarks
    )
    VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)
  `;

  const values = [
    year,
    sem,
    date,
    branch,
    section,
    subject,
    ques1,
    ques2i,
    ques2ii,
    ques2iii,
    ques2iv,
    ques2v,
    ques3,
    ques4,
    remarks
  ];

  db.query(sql, values, (err) => {
    if (err) {
      return res.status(500).json({
        status: "error",
        message: err.sqlMessage
      });
    }

    res.json({
      status: "success",
      message: "Library feedback submitted successfully"
    });
  });
});

// VIEW FEEDBACK
app.get("/api/feedback", (req, res) => {
  const sql = `
    SELECT *
    FROM student_feedback
    ORDER BY feedback_id DESC
  `;

  db.query(sql, (err, result) => {
    if (err) {
      return res.status(500).json({
        status: "error",
        message: err.sqlMessage
      });
    }

    res.json(result);
  });
});

// SERVER START
app.listen(3000, () => {
  console.log("Server started on port 3000");
});