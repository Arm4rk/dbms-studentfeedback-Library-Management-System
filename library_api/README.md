# ⚙️ Library API — Node.js REST Backend

The shared REST API backend for the **Library Management System**. Built with **Node.js + Express**, it serves as the single data layer between the MySQL database and both client apps — the C# desktop application and the PHP student feedback portal.

---

## 🗂️ Project Structure

```
library_api/
├── server.js          # Express app — all routes and DB logic
├── package.json       # Project metadata and dependencies
└── package-lock.json  # Locked dependency tree
```

---

## 🛠️ Tech Stack

| | |
|---|---|
| Runtime | Node.js |
| Framework | Express v5 |
| Database Driver | mysql2 |
| Other | cors, body-parser, crypto (built-in) |

---

## ⚙️ Setup & Installation

### Prerequisites
- [Node.js](https://nodejs.org/) v18 or later
- MySQL / MariaDB running with the `common_library_db` database already imported

### 1. Install dependencies

```bash
cd library_api
npm install
```

### 2. Configure the database connection

Open `server.js` and update the connection block if needed:

```js
const db = mysql.createConnection({
  host: "localhost",
  user: "root",
  password: "",          // update if your MySQL has a password
  database: "common_library_db"
});
```

### 3. Start the server

```bash
node server.js
```

The API will be available at **`http://localhost:3000`**.

You should see in the terminal:
```
Connected to common_library_db
Server started on port 3000
```

---

## 📡 API Endpoints

### 🔧 Health & Test

| Method | Endpoint | Description |
|---|---|---|
| `GET` | `/` | Check if the API is running |
| `GET` | `/health` | Returns `{ status: "ok", database: "common_library_db" }` |

---

### 🔐 Authentication

#### `POST /login`
Authenticates a user. Passwords are verified using **MD5 hashing** against the `lms_user` table.

**Request body:**
```json
{
  "email": "admin@example.com",
  "password": "yourpassword"
}
```

**Success response:**
```json
{
  "success": true,
  "message": "Login successful",
  "user": { ...user row from lms_user... }
}
```

**Failure response:**
```json
{
  "success": false,
  "message": "Invalid email or password"
}
```

---

### 📚 Books

#### `GET /books`
Returns all books from `lms_books`, ordered by `BookID DESC`.

**Response:** Array of book objects.

---

#### `POST /books`
Adds a new book to `lms_books`.

**Request body:**
```json
{
  "title": "Clean Code",
  "isbn": "9780132350884",
  "author": "Robert C. Martin",
  "genre": "Technology",
  "description": "A handbook of agile software craftsmanship.",
  "publishedDate": "2008-08-01",
  "quantity": 3
}
```
> `title` and `isbn` are **required**. All other fields are optional.

**Success response:**
```json
{
  "status": "success",
  "message": "Book added successfully",
  "insertedId": 42
}
```

---

### 📖 Book Issuance

#### `GET /issue`
Returns all records from `lib_book_issue`.

**Response:** Array of issue records.

---

#### `POST /issue`
Records a book being issued to a borrower. Inserts into `lib_book_issue` with `status = "Issued"`.

**Request body:**
```json
{
  "member_id": "1",
  "book_id": "9780132350884",
  "borrower_name": "Juan Dela Cruz",
  "issue_date": "2026-05-22",
  "return_date": "2026-06-05"
}
```
> All fields are **required**.

**Success response:**
```json
{
  "status": "success",
  "message": "Book issued successfully",
  "insertedId": 15
}
```

---

### 📝 Student Feedback

#### `GET /api/feedback`
Returns all feedback records from `student_feedback`, ordered by `feedback_id DESC`.

**Response:** Array of feedback objects.

---

#### `POST /api/feedback`
Saves a new student feedback submission to `student_feedback`.

**Request body:**
```json
{
  "year": "2026",
  "sem": "2nd",
  "date": "2026-05-22",
  "branch": "BSIT",
  "section": "3A",
  "subject": "Overall Library Service",
  "ques1": "5",
  "ques-2i": "4",
  "ques-2ii": "5",
  "ques-2iii": "4",
  "ques-2iv": "3",
  "ques-2v": "5",
  "ques3": "4",
  "ques4": "5",
  "remarks": "Great service overall!"
}
```

> Note: Sub-questions use the keys `ques-2i` through `ques-2v` (with a hyphen), which the API maps internally to `ques2i`–`ques2v` in the database.

**Success response:**
```json
{
  "status": "success",
  "message": "Library feedback submitted successfully"
}
```

---

## 🗄️ Database Tables Used

| Table | Used by |
|---|---|
| `lms_user` | `/login` — admin credential lookup |
| `lms_books` | `/books` — book catalog |
| `lib_book_issue` | `/issue` — borrow records |
| `student_feedback` | `/api/feedback` — student ratings |

---

## 🔒 Security Notes

- Passwords are hashed with **MD5** before comparing against the database. For production use, consider upgrading to **bcrypt**.
- **CORS is enabled for all origins** (`cors()` with no config). Restrict this in production by passing an `origin` option.
- There is currently **no authentication middleware** protecting routes other than `/login`. Adding JWT or session tokens is recommended for production deployments.

---

## 📌 Notes

- The server runs on **port 3000** by default. Change the last line of `server.js` to use a different port.
- The database connection is a single persistent connection using `mysql2`. If the connection drops, restart the server.
- Both the C# desktop app and the PHP feedback portal depend on this API running at `http://localhost:3000`.
