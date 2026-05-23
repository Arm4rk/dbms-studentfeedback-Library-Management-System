# 📚 Library Management System — Desktop App (C# / .NET)

A Windows Forms desktop application for managing a library's books and book-issue records. Built with **C# (.NET Framework 4.8)** and connected to a shared **Node.js REST API** (`server.js`) instead of talking directly to the database — keeping the data layer cleanly separated.

---

## 🗂️ Project Structure

```
Library-Management-System1 - NODE/
├── Library Management System.sln          # Visual Studio solution file
├── LICENSE
└── Library Management System/
    ├── Program.cs                          # App entry point
    ├── App.config                          # .NET runtime & assembly config
    ├── packages.config                     # NuGet package references
    ├── Form1.cs / .Designer.cs             # Splash / Welcome screen
    ├── UserLogin.cs / .Designer.cs         # Login form
    ├── mainDashbboard.cs / .Designer.cs    # Main dashboard
    ├── addBook.cs / .Designer.cs           # Add book form
    ├── issueBook.cs / .Designer.cs         # Issue book form
    ├── FeedbackDetails.cs / .Designer.cs   # View student feedback
    └── Properties/
        ├── AssemblyInfo.cs
        ├── Resources.Designer.cs
        └── Settings.Designer.cs
```

---

## ✨ Features

### 🔐 Login (`UserLogin`)
- Email + password login form with a show/hide password toggle
- Authenticates against the Node.js API (`POST /login`)
- On success, opens the main dashboard with the user's role
- Admin role unlocks the **Add Book** button; non-admin users see it disabled

### 🏠 Dashboard (`mainDashbboard`)
- Central navigation hub
- Role-aware: **Add Book** is restricted to Admin users
- Buttons to navigate to: Add Book, Issue Book, Feedback Details
- Logout returns to the login screen; Exit closes the application

### ➕ Add Book (`addBook`)
- Fields: Book Name, ISBN, Author, Edition, Description, Published Date
- Submits to `POST /books` on the Node.js API
- Validates that Book Name and ISBN are not empty before sending
- Clears the form on successful save

### 📖 Issue Book (`issueBook`)
- Loads the book list dynamically from `GET /books` on form open
- Fields: Book selection (dropdown), Borrower Name, Issue Date, Return Date
- Submits to `POST /issue` on the Node.js API
- Clears the form after a successful issue

### 📋 Feedback Details (`FeedbackDetails`)
- Fetches all student feedback from `GET /api/feedback`
- Displays records in a `DataGridView` with readable column headers:

| Column | Maps to |
|---|---|
| ID | `feedback_id` |
| Academic Year | `academic_year` |
| Semester | `semester` |
| Date | `feedback_date` |
| Department / Course | `branch` |
| Year & Section | `section` |
| Feedback Category | `subject` |
| Book Availability | `ques1` |
| Borrowing Process | `ques2i` |
| Returning Process | `ques2ii` |
| Staff Assistance | `ques2iii` |
| Cleanliness & Organization | `ques2iv` |
| Finding Resources | `ques2v` |
| System Usefulness | `ques3` |
| Overall Service | `ques4` |
| Remarks | `remarks` |
| Date Submitted | `created_at` |

- **Refresh** button to reload data without restarting
- Shows total feedback count as a label

---

## 🛠️ Tech Stack

| Layer | Technology |
|---|---|
| Language | C# |
| Framework | .NET Framework 4.8 |
| UI | Windows Forms (WinForms) |
| HTTP Client | `System.Net.Http.HttpClient` |
| JSON Serialization | `Newtonsoft.Json`, `System.Text.Json` |
| Backend API | Node.js + Express (separate project) |
| Database | MySQL / MariaDB (accessed via the Node.js API) |
| IDE | Microsoft Visual Studio |

---

## ⚙️ Prerequisites

- **Windows OS** (WinForms is Windows-only)
- [Visual Studio](https://visualstudio.microsoft.com/) 2019 or later (with .NET desktop workload)
- **.NET Framework 4.8** runtime
- The **Node.js REST API** (`library_api/server.js`) running on `http://localhost:3000`
- **MySQL / MariaDB** running with the `common_library_db` database set up

---

## 🚀 Setup & Running

### 1. Set up the Database

Import the shared schema file into MySQL:

```bash
mysql -u root -p common_library_db < common_library_db.sql
```

Or use phpMyAdmin's **Import** tab with `common_library_db.sql`.

---

### 2. Start the Node.js API

The desktop app communicates exclusively through the REST API — it must be running first.

```bash
cd library_api
npm install
node server.js
# Running at http://localhost:3000
```

---

### 3. Open and Run the Desktop App

1. Open `Library Management System.sln` in **Visual Studio**.
2. Restore NuGet packages if prompted (**Tools → NuGet Package Manager → Restore**).
3. Press **F5** (or **Debug → Start Debugging**) to build and run.
4. The **Welcome / Splash screen** appears — click **Login** to proceed.
5. Enter admin credentials stored in the `lms_user` table of `common_library_db`.

---

## 🔗 API Endpoints Used

| Form | Method | Endpoint | Purpose |
|---|---|---|---|
| `UserLogin` | `POST` | `/login` | Authenticate user |
| `addBook` | `POST` | `/books` | Add a new book |
| `issueBook` | `GET` | `/books` | Load book list into dropdown |
| `issueBook` | `POST` | `/issue` | Record a book issue |
| `FeedbackDetails` | `GET` | `/api/feedback` | Load all student feedback |

All requests are sent to `http://localhost:3000` by default.

---

## 📌 Notes

- The Node.js API **must be running on port 3000** before launching the app — all forms depend on it.
- The app uses **async/await** throughout for non-blocking API calls, keeping the UI responsive.
- Admin credentials are stored in the `lms_user` table and passwords are verified via the API (MD5-hashed).
- The **Add Book** button on the dashboard is disabled for non-Admin roles at runtime.
- `Form1` acts as a welcome/splash screen — actual login logic lives in `UserLogin`.
