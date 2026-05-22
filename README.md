# 📚 Library Management System

A full-stack Library Management System built as a DBMS project, combining three integrated components: a **C# Desktop Application**, a **PHP Student Feedback Portal**, and a **Node.js REST API** — all powered by a shared **MySQL database**.

---

## 🗂️ Project Structure

```
Library-Management-System/
├── Library-Management-System1 - NODE/   # C# Windows Forms Desktop App
│   └── Library Management System/
│       ├── addBook.cs
│       ├── issueBook.cs
│       ├── mainDashbboard.cs
│       ├── FeedbackDetails.cs
│       ├── UserLogin.cs
│       └── ...
├── dbms_studentfeedback/                # PHP Student Feedback Portal
│   ├── index.php                        # Main feedback form
│   ├── admin.php                        # Admin login
│   ├── adminpage.php                    # Admin dashboard
│   ├── php/
│   │   ├── config.php                   # DB connection
│   │   ├── checklogin.php
│   │   └── feedback.php
│   └── css/
├── library_api/                         # Node.js REST API (Express)
│   ├── server.js                        # API entry point
│   └── package.json
└── common_library_db.sql                # Shared MySQL database schema + seed data
```

---

## ✨ Features

### 🖥️ C# Desktop Application
- User login system
- Add, view, update, and delete **books** and **members**
- **Issue** and **return** books
- Track borrowing records and payment history
- View student feedback submissions

### 🌐 PHP Student Feedback Portal
- Students fill out a feedback form with academic details (year, semester, branch, section, subject)
- Ratings across multiple criteria
- Admin login to view all submitted feedback in a table
- Logout to protect admin data

### ⚙️ Node.js REST API (Express)
| Method | Endpoint       | Description              |
|--------|----------------|--------------------------|
| POST   | `/login`       | Authenticate a user      |
| GET    | `/books`       | Get all books            |
| POST   | `/books`       | Add a new book           |
| GET    | `/issue`       | View all issued books    |
| POST   | `/issue`       | Issue a book to a member |
| GET    | `/api/feedback`| View all feedback        |
| POST   | `/api/feedback`| Submit student feedback  |

---

## 🛠️ Tech Stack

| Layer        | Technology                        |
|--------------|-----------------------------------|
| Desktop App  | C# (.NET, Windows Forms)          |
| Web Frontend | PHP, HTML, CSS                    |
| REST API     | Node.js, Express.js               |
| Database     | MySQL / MariaDB                   |
| DB Driver    | mysql2 (Node), MySql.Data (C#)    |

---

## ⚙️ Setup & Installation

### Prerequisites
- [XAMPP](https://www.apachefriends.org/download.html) (Apache + MySQL) **or** a standalone MySQL/MariaDB server
- [Node.js](https://nodejs.org/) (v18+ recommended)
- [Visual Studio](https://visualstudio.microsoft.com/) (for the C# desktop app)

---

### 1. Database Setup

1. Start **MySQL** (via XAMPP Control Panel or your MySQL service).
2. Open **phpMyAdmin** at `http://localhost/phpmyadmin/` or use the MySQL CLI.
3. Create a database named `common_library_db`.
4. Import the schema and seed data:
   ```
   mysql -u root -p common_library_db < common_library_db.sql
   ```
   Or use phpMyAdmin's **Import** tab to upload `common_library_db.sql`.

---

### 2. PHP Feedback Portal

1. Start **Apache** via the XAMPP Control Panel.
2. Copy the `dbms_studentfeedback/` folder into:
   ```
   C:\xampp\htdocs\dbms_studentfeedback\
   ```
3. Update the database credentials in `dbms_studentfeedback/php/config.php` if needed.
4. Open your browser and go to:
   ```
   http://localhost/dbms_studentfeedback/
   ```

---

### 3. Node.js REST API

1. Navigate to the `library_api/` directory:
   ```bash
   cd library_api
   ```
2. Install dependencies:
   ```bash
   npm install
   ```
3. Update the database connection in `server.js` if your MySQL credentials differ from the defaults (`root` / no password):
   ```js
   const db = mysql.createConnection({
     host: "localhost",
     user: "root",
     password: "",           // update if needed
     database: "common_library_db"
   });
   ```
4. Start the server:
   ```bash
   node server.js
   ```
5. The API will be available at `http://localhost:3000`.

---

### 4. C# Desktop Application

1. Open the solution file in Visual Studio:
   ```
   Library-Management-System1 - NODE/Library Management System.sln
   ```
2. Restore NuGet packages if prompted.
3. Update the database connection string in the project settings or `App.config` to match your MySQL server credentials.
4. Build and run the project (`F5` or **Debug > Start Debugging**).

---

## 🗄️ Database Schema

The shared `common_library_db` database contains the following tables:

| Table              | Description                          |
|--------------------|--------------------------------------|
| `lms_user`         | Registered users / librarians        |
| `lms_books`        | Book catalog (title, ISBN, author, genre, quantity) |
| `lms_members`      | Library members                      |
| `lib_book_issue`   | Book issue/return records            |
| `student_feedback` | Student feedback submissions         |

---

## 📡 API Usage Examples

**Add a book:**
```bash
curl -X POST http://localhost:3000/books \
  -H "Content-Type: application/json" \
  -d '{"title": "Clean Code", "isbn": "9780132350884", "author": "Robert C. Martin", "quantity": 3}'
```

**Submit feedback:**
```bash
curl -X POST http://localhost:3000/api/feedback \
  -H "Content-Type: application/json" \
  -d '{"year": "2025-2026", "sem": "2", "date": "2026-05-22", "branch": "CS", "section": "A", "subject": "DBMS", "ques1": "5", "ques3": "4", "ques4": "5"}'
```

---

## 📝 Notes

- The Node.js API runs on port **3000** by default.
- The PHP portal communicates directly with MySQL via the `config.php` connection settings.
- The C# app connects to the same `common_library_db` database.
- Make sure MySQL is running before starting any component.
- The `node_modules/` folder is included in the zip but can be regenerated with `npm install`.

---

## 📄 License

This project is open-source and available under the [MIT License](LICENSE).
