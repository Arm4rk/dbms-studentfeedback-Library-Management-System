<!DOCTYPE html>
<html>
  <head>
    <title>StudentFeedback</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta http-equiv="content-Type" content="text/html; charset=utf-8" />

    <script type="application/x-javascript">
      addEventListener("load", function() {
        setTimeout(hideURLbar, 0);
      }, false);

      function hideURLbar() {
        window.scrollTo(0, 1);
      }
    </script>

    <link href="css/styles.css" rel="stylesheet" type="text/css" media="all" />

    <style>
      body {
        margin: 0;
        font-family: Arial, sans-serif;
        background: rgb(128, 64, 64);
        min-height: 100vh;
        color: #111827;
      }

      .admin-login {
        text-align: right;
        padding: 20px 40px 0 0;
      }

      #admin {
        background-color: rgb(128, 64, 64);
        color: white;
        border: 2px solid white;
        padding: 10px 25px;
        border-radius: 8px;
        cursor: pointer;
        font-weight: bold;
      }

      #admin:hover {
        background-color: rgb(105, 50, 50);
      }

      .main-heading {
        text-align: center;
        color: white;
        font-size: 38px;
        margin-top: 20px;
        margin-bottom: 5px;
        text-transform: uppercase;
        letter-spacing: 1px;
      }

      .subtitle {
        text-align: center;
        color: #f8fafc;
        font-size: 18px;
        margin-bottom: 30px;
      }

      .container {
        width: 85%;
        max-width: 950px;
        margin: auto;
        background: white;
        padding: 30px;
        border-radius: 18px;
        box-shadow: 0 10px 30px rgba(0,0,0,0.25);
      }

      .container h3 {
        text-align: center;
        background-color: rgb(128, 64, 64);
        color: white;
        padding: 15px;
        border-radius: 10px;
        margin-bottom: 30px;
      }

      .student-details {
        display: grid;
        grid-template-columns: 1fr 1fr;
        gap: 18px;
        margin-bottom: 30px;
      }

      .form-group {
        display: flex;
        flex-direction: column;
      }

      label {
        font-weight: bold;
        margin-bottom: 6px;
        color: rgb(128, 64, 64);
      }

      select,
      input[type="date"],
      input[type="text"],
      textarea {
        padding: 10px;
        border: 1px solid #cbd5e1;
        border-radius: 8px;
        font-size: 15px;
      }

      textarea {
        width: 100%;
        resize: vertical;
      }

      .student-feedback {
        background-color: #f8fafc;
        padding: 25px;
        border-radius: 14px;
        border-left: 6px solid rgb(128, 64, 64);
      }

      .question-box {
        background: white;
        padding: 18px;
        margin-bottom: 18px;
        border-radius: 12px;
        border: 1px solid #e5e7eb;
      }

      .question-box h4 {
        margin-top: 0;
        color: rgb(128, 64, 64);
      }

      .rating-options {
        display: flex;
        flex-wrap: wrap;
        gap: 15px;
        margin-top: 12px;
      }

      .rating-options label {
        font-weight: normal;
        background-color: #f1f5f9;
        color: #111827;
        padding: 8px 12px;
        border-radius: 8px;
        cursor: pointer;
      }

      .rating-options label:hover {
        background-color: #eadada;
      }

      .submit-form {
        text-align: center;
        margin-top: 30px;
      }

      #submit {
        background-color: rgb(128, 64, 64);
        color: white;
        border: none;
        padding: 14px 45px;
        border-radius: 10px;
        font-size: 17px;
        font-weight: bold;
        cursor: pointer;
      }

      #submit:hover {
        background-color: rgb(105, 50, 50);
      }

      .copyright-text {
        text-align: center;
        color: white;
        padding: 25px;
        margin-top: 30px;
      }

      @media (max-width: 768px) {
        .student-details {
          grid-template-columns: 1fr;
        }

        .container {
          width: 90%;
          padding: 20px;
        }

        .main-heading {
          font-size: 28px;
        }
      }
    </style>
  </head>

  <body>
    <form action="php/admin.php" method="POST">
      <div class="admin-login">
        <input type="submit" name="admin" value="Admin" id="admin" />
      </div>
    </form>

    <h1 class="main-heading">Library Management System Feedback</h1>
    <p class="subtitle">
      Help us improve our library services, book availability, and borrowing experience.
    </p>

    <div class="container">
      <h3>
        Fill out this feedback form based on your experience using the library.
      </h3>

      <form action="http://localhost:3000/api/feedback" method="post" class="student-form">
        <div class="student-details">
          <div class="form-group">
            <label for="year">Academic Year</label>
            <select name="year" id="year" required>
              <option value="2024">2024</option>
              <option value="2025">2025</option>
              <option value="2026">2026</option>
            </select>
          </div>

          <div class="form-group">
            <label for="sem">Semester</label>
            <select name="sem" id="sem" required>
              <option value="1st">1st Semester</option>
              <option value="2nd">2nd Semester</option>
              <option value="Summer">Summer</option>
            </select>
          </div>

          <div class="form-group">
            <label for="date">Date of Feedback</label>
            <input type="date" id="date" name="date" required />
          </div>

          <div class="form-group">
            <label for="branch">Department / Course</label>
            <select name="branch" id="branch" required>
              <option value="BSIT">BSIT</option>
              <option value="BSCS">BSCS</option>
              <option value="BSED">BSED</option>
              <option value="BSBA">BSBA</option>
              <option value="Other">Other</option>
            </select>
          </div>

          <div class="form-group">
            <label for="section">Year & Section</label>
            <select name="section" id="section" required>
              <option value="1A">1A</option>
              <option value="1B">1B</option>
              <option value="2A">2A</option>
              <option value="2B">2B</option>
              <option value="3A">3A</option>
              <option value="3B">3B</option>
              <option value="4A">4A</option>
              <option value="4B">4B</option>
            </select>
          </div>

          <div class="form-group">
            <label for="subject">Feedback Category</label>
            <select name="subject" id="subject" required>
              <option value="Book Availability">Book Availability</option>
              <option value="Borrowing Process">Borrowing Process</option>
             
              <option value="Library Staff Service">Library Staff Service</option>
              <option value="Library Facilities">Library Facilities</option>
              <option value="Overall Library Service">Overall Library Service</option>
            </select>
          </div>
        </div>

        <div class="student-feedback">
          <div class="question-box">
            <h4>1) How satisfied are you with the availability of books in the library?</h4>
            <div class="rating-options">
              <label><input type="radio" name="ques1" value="5" required /> 5 - Excellent</label>
              <label><input type="radio" name="ques1" value="4" /> 4 - Very Good</label>
              <label><input type="radio" name="ques1" value="3" /> 3 - Good</label>
              <label><input type="radio" name="ques1" value="2" /> 2 - Average</label>
              <label><input type="radio" name="ques1" value="1" /> 1 - Poor</label>
            </div>
          </div>

          <div class="question-box">
            <h4>2) How do you rate the borrowing process of books?</h4>
            <div class="rating-options">
              <label><input type="radio" name="ques-2i" value="5" required /> 5 - Excellent</label>
              <label><input type="radio" name="ques-2i" value="4" /> 4 - Very Good</label>
              <label><input type="radio" name="ques-2i" value="3" /> 3 - Good</label>
              <label><input type="radio" name="ques-2i" value="2" /> 2 - Average</label>
              <label><input type="radio" name="ques-2i" value="1" /> 1 - Poor</label>
            </div>
          </div>

          <div class="question-box">
            <h4>3) How do you rate the returning process of books?</h4>
            <div class="rating-options">
              <label><input type="radio" name="ques-2ii" value="5" required /> 5 - Excellent</label>
              <label><input type="radio" name="ques-2ii" value="4" /> 4 - Very Good</label>
              <label><input type="radio" name="ques-2ii" value="3" /> 3 - Good</label>
              <label><input type="radio" name="ques-2ii" value="2" /> 2 - Average</label>
              <label><input type="radio" name="ques-2ii" value="1" /> 1 - Poor</label>
            </div>
          </div>

          <div class="question-box">
            <h4>4) How helpful and approachable are the library staff?</h4>
            <div class="rating-options">
              <label><input type="radio" name="ques-2iii" value="5" required /> 5 - Excellent</label>
              <label><input type="radio" name="ques-2iii" value="4" /> 4 - Very Good</label>
              <label><input type="radio" name="ques-2iii" value="3" /> 3 - Good</label>
              <label><input type="radio" name="ques-2iii" value="2" /> 2 - Average</label>
              <label><input type="radio" name="ques-2iii" value="1" /> 1 - Poor</label>
            </div>
          </div>

          <div class="question-box">
            <h4>5) How do you rate the cleanliness and organization of the library?</h4>
            <div class="rating-options">
              <label><input type="radio" name="ques-2iv" value="5" required /> 5 - Excellent</label>
              <label><input type="radio" name="ques-2iv" value="4" /> 4 - Very Good</label>
              <label><input type="radio" name="ques-2iv" value="3" /> 3 - Good</label>
              <label><input type="radio" name="ques-2iv" value="2" /> 2 - Average</label>
              <label><input type="radio" name="ques-2iv" value="1" /> 1 - Poor</label>
            </div>
          </div>

          <div class="question-box">
            <h4>6) How easy is it to find the books or resources you need?</h4>
            <div class="rating-options">
              <label><input type="radio" name="ques-2v" value="5" required /> 5 - Excellent</label>
              <label><input type="radio" name="ques-2v" value="4" /> 4 - Very Good</label>
              <label><input type="radio" name="ques-2v" value="3" /> 3 - Good</label>
              <label><input type="radio" name="ques-2v" value="2" /> 2 - Average</label>
              <label><input type="radio" name="ques-2v" value="1" /> 1 - Poor</label>
            </div>
          </div>

          <div class="question-box">
            <h4>7) How useful is the library system in managing book records and transactions?</h4>
            <div class="rating-options">
              <label><input type="radio" name="ques3" value="5" required /> 5 - Excellent</label>
              <label><input type="radio" name="ques3" value="4" /> 4 - Very Good</label>
              <label><input type="radio" name="ques3" value="3" /> 3 - Good</label>
              <label><input type="radio" name="ques3" value="2" /> 2 - Average</label>
              <label><input type="radio" name="ques3" value="1" /> 1 - Poor</label>
            </div>
          </div>

          <div class="question-box">
            <h4>8) Overall, how do you rate the library service?</h4>
            <div class="rating-options">
              <label><input type="radio" name="ques4" value="5" required /> 5 - Excellent</label>
              <label><input type="radio" name="ques4" value="4" /> 4 - Very Good</label>
              <label><input type="radio" name="ques4" value="3" /> 3 - Good</label>
              <label><input type="radio" name="ques4" value="2" /> 2 - Average</label>
              <label><input type="radio" name="ques4" value="1" /> 1 - Poor</label>
            </div>
          </div>

          <div class="question-box">
            <h4>9) Remarks or Suggestions</h4>
            <textarea name="remarks" rows="5" placeholder="Write your comments, suggestions, or concerns about the library service..."></textarea>
          </div>
        </div>

        <div class="submit-form">
          <input type="submit" name="submit" value="Submit Feedback" id="submit" />
        </div>
      </form>

      <br />
    </div>

    <div class="copyright-text">
      <p>© Integrated Library Management and Student Feedback System</p>
    </div>
  </body>
</html>