# 📝 Student Feedback Portal — Library Management System

A web-based student feedback portal for libraries, built with **PHP**, **CSS**, and a **Node.js REST API** backend. Students can submit structured feedback about library services, and admins can securely view all responses through a protected dashboard.

---

## 🗂️ Project Structure

```
dbms_studentfeedback/
├── index.php           # Main student feedback form
├── admin.php           # Admin login page
├── adminpage.php       # Admin dashboard (view all feedback)
├── logout.php          # Admin session logout
├── css/
│   ├── styles.css      # Main stylesheet
│   ├── styles.less     # LESS source
│   ├── styles1.css
│   └── styles2.css
└── php/
    ├── config.php      # API base URL config
    ├── checklogin.php  # Handles admin login via Node.js API
    ├── feedback.php    # Submits feedback to Node.js API
    ├── admin.php       # Admin session check
    └── logout.php      # Session destroy handler
```

> **Note:** This portal communicates with a Node.js REST API (`server.js` running on `http://localhost:3000`) — it does **not** connect directly to the database.

---

## ✨ Features

- Students fill out a feedback form with their academic details and rate library services
- Admin login protected by session — credentials verified through the Node.js API
- Admin dashboard displays all submitted feedback in a table
- Logout button to protect admin data after review

---

## 📋 Feedback Form Fields

### Student Details
| Field | Options |
|---|---|
| Academic Year | 2024, 2025, 2026 |
| Semester | 1st, 2nd, Summer |
| Date of Feedback | Date picker |
| Department / Course | BSIT, BSCS, BSED, BSBA, Other |
| Year & Section | 1A, 1B, 2A, 2B, 3A, 3B, 4A, 4B |
| Feedback Category | Book Availability, Borrowing Process, Library Staff Service, Library Facilities, Overall Library Service |

### Rating Questions (1 = Poor → 5 = Excellent)
| # | Question |
|---|---|
| 1 | How satisfied are you with the availability of books in the library? |
| 2i | How do you rate the borrowing process of books? |
| 2ii | How do you rate the returning process of books? |
| 2iii | How helpful and approachable are the library staff? |
| 2iv | How do you rate the cleanliness and organization of the library? |
| 2v | How easy is it to find the books or resources you need? |
| 3 | How useful is the library system in managing book records and transactions? |
| 4 | Overall, how do you rate the library service? |
| 9 | Remarks or Suggestions (open text) |

---

## 🛠️ Tech Stack

| Layer | Technology |
|---|---|
| Frontend / Views | PHP, HTML, CSS |
| Styling | CSS, LESS |
| Backend API | Node.js + Express (separate repo/folder) |
| Database | MySQL / MariaDB (via Node.js API) |
| Session Auth | PHP Sessions |
| HTTP Client | PHP cURL |

---

## ⚙️ Setup & Installation

### Prerequisites
- [XAMPP](https://www.apachefriends.org/download.html) (Apache + MySQL) or any PHP server with cURL enabled
- Node.js REST API (`library_api/server.js`) **running on port 3000** — this is required for login and feedback submission to work

---

### 1. Start the Node.js API

Make sure the backend API is running first:

```bash
cd library_api
npm install
node server.js
# API should be running at http://localhost:3000
```

---

### 2. Set Up the PHP Portal

1. Start **Apache** via the XAMPP Control Panel.

2. Copy the `dbms_studentfeedback/` folder into your web root:
   ```
   C:\xampp\htdocs\dbms_studentfeedback\
   ```

3. The API base URL is configured in `php/config.php`:
   ```php
   $API_BASE_URL = "http://localhost:3000";
   ```
   Update this if API runs on a different host or port.

4. Open your browser and navigate to:
   ```
   http://localhost/dbms_studentfeedback/
   ```

---

## 🔐 Admin Access

1. On the main feedback page, click the **Admin** button (top-right corner).
2. Log in with the admin email and password stored in the database (`lms_user` table).
3. After login, you'll be redirected to the **Admin Dashboard** where all submitted feedback is displayed in a table.
4. Click **Logout** when done to end the session.

> Admin credentials are verified through the Node.js `/login` API endpoint using MD5-hashed passwords.

---

## 🔗 API Endpoints Used

| Method | Endpoint | Description |
|---|---|---|
| `POST` | `/login` | Verify admin credentials |
| `POST` | `/api/feedback` | Submit student feedback |
| `GET` | `/api/feedback` | Retrieve all feedback (admin view) |

---

## 📌 Notes

- The Node.js API **must be running** before using the portal — login and feedback submission both rely on it via PHP cURL.
- Timezone is set to `Asia/Manila` in `config.php`.
- Feedback is stored in the `student_feedback` table of the `common_library_db` MySQL database (managed by the API).
