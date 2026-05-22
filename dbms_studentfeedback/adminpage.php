<?php
session_start();

if (!isset($_SESSION['login_user'])) {
    header("Location: admin.php");
    exit();
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8" />
  <title>Library Feedback Details</title>

  <style>
    * {
      box-sizing: border-box;
    }

    body {
      margin: 0;
      font-family: "Segoe UI", Arial, sans-serif;
      background-color: rgb(128, 64, 64);
      min-height: 100vh;
      color: #0f172a;
    }

    .main {
      width: 100%;
      min-height: 100vh;
      background-color: rgb(128, 64, 64);
      padding-top: 25px;
      padding-bottom: 35px;
    }

    .system-title {
      color: white;
      font-size: 34px;
      font-weight: 800;
      text-align: center;
      margin: 0;
      letter-spacing: 1px;
    }

    .system-subtitle {
      color: #f8fafc;
      text-align: center;
      font-size: 15px;
      margin-top: 8px;
    }

    .divider-accent {
      width: 150px;
      height: 4px;
      background-color: #f8fafc;
      margin: 14px auto 18px auto;
      border-radius: 2px;
    }

    .top-user {
      color: #f8fafc;
      text-align: center;
      font-size: 14px;
      margin-bottom: 18px;
    }

    .top-user span {
      color: #fef3c7;
      font-weight: 700;
    }

    .logout {
      text-align: center;
      margin-bottom: 18px;
    }

    .logout input {
      background-color: rgb(128, 64, 64);
      color: white;
      border: 2px solid white;
      padding: 10px 28px;
      font-weight: bold;
      border-radius: 4px;
      cursor: pointer;
      transition: 0.2s;
    }

    .logout input:hover {
      background-color: rgb(105, 50, 50);
    }

    .card {
      width: 92%;
      max-width: 1080px;
      margin: 0 auto;
      background-color: #f8fafc;
      padding: 28px 35px 20px 35px;
      border-radius: 0;
      box-shadow: 0 10px 30px rgba(0, 0, 0, 0.35);
      overflow-x: auto;
    }

    .page-title {
      text-align: center;
      font-size: 28px;
      font-weight: 800;
      color: #0f172a;
      margin: 0;
    }

    .page-subtitle {
      text-align: center;
      font-size: 15px;
      color: #475569;
      margin-top: 8px;
      margin-bottom: 10px;
    }

    .badge {
      width: 150px;
      height: 28px;
      background-color: rgb(128, 64, 64);
      color: white;
      margin: 0 auto 18px auto;
      font-size: 12px;
      font-weight: bold;
      display: flex;
      align-items: center;
      justify-content: center;
      letter-spacing: 0.5px;
    }

    .summary-box {
      background-color: #f5eeee;
      color: rgb(128, 64, 64);
      font-weight: bold;
      padding: 10px 14px;
      margin: 10px 0 15px 0;
      border-left: 5px solid rgb(128, 64, 64);
      min-height: 35px;
      display: flex;
      align-items: center;
    }

    table {
      width: 100%;
      border-collapse: collapse;
      background-color: white;
      font-size: 13px;
      border: 1px solid #e2e8f0;
    }

    th {
      background-color: rgb(128, 64, 64);
      color: white;
      padding: 10px;
      text-align: left;
      white-space: nowrap;
      font-weight: 600;
      border-bottom: 1px solid #e2e8f0;
    }

    td {
      padding: 9px 10px;
      border-bottom: 1px solid #e2e8f0;
      color: #0f172a;
      white-space: nowrap;
    }

    tr:nth-child(even) {
      background-color: #f8fafc;
    }

    tr:hover {
      background-color: #eadada;
    }

    .remarks {
      max-width: 220px;
      white-space: normal;
      text-align: left;
    }

    .rating {
      font-weight: bold;
      color: rgb(128, 64, 64);
      text-align: center;
    }

    .button-row {
      text-align: center;
      margin-top: 20px;
    }

    .button-row button,
    .button-row a {
      display: inline-block;
      text-decoration: none;
      border: none;
      color: white;
      font-weight: bold;
      padding: 10px 28px;
      margin: 0 8px;
      cursor: pointer;
      font-size: 14px;
      border-radius: 0;
    }

    .refresh-btn {
      background-color: rgb(128, 64, 64);
    }

    .back-btn {
      background-color: rgb(128, 64, 64);
    }

    .refresh-btn:hover,
    .back-btn:hover {
      background-color: rgb(105, 50, 50);
    }

    .no-data {
      text-align: center;
      padding: 20px;
      color: #dc2626;
      font-weight: bold;
      background-color: white;
      border: 1px solid #e2e8f0;
    }

    .error-box {
      background-color: #fee2e2;
      color: #991b1b;
      padding: 15px;
      text-align: center;
      font-weight: bold;
      border: 1px solid #fecaca;
    }

    .version {
      color: #f8fafc;
      text-align: center;
      font-size: 12px;
      margin-top: 12px;
    }
  </style>
</head>

<body>
  <div class="main">
    <h1 class="system-title">LIBRARY MANAGEMENT SYSTEM</h1>

    <div class="system-subtitle">
      View student feedback records from the library feedback system.
    </div>

    <div class="divider-accent"></div>

    <div class="top-user">
      Logged in as:
      <span><?php echo htmlspecialchars($_SESSION['login_user']); ?></span>
      |
      Role:
      <span><?php echo htmlspecialchars($_SESSION['role']); ?></span>
    </div>

    <form action="php/logout.php" method="POST" class="logout">
      <input type="submit" value="LOG OUT" name="logout" />
    </form>

    <div class="card">
      <h2 class="page-title">Library Feedback Details</h2>

      <div class="page-subtitle">
        Student Feedback Records for Library Management System
      </div>

      <div class="badge">FEEDBACK</div>

      <?php
        $api_url = "http://localhost:3000/api/feedback";
        $response = @file_get_contents($api_url);

        if ($response === FALSE) {
          echo "<div class='error-box'>";
          echo "Cannot connect to Node.js API. Please make sure server.js is running on port 3000.";
          echo "</div>";
        } else {
          $feedbacks = json_decode($response, true);

          if (!empty($feedbacks)) {
            $totalFeedback = count($feedbacks);

            echo "<div class='summary-box'>";
            echo "Total Library Feedback Records: " . $totalFeedback;
            echo "</div>";

            echo "<table>
                    <tr>
                      <th>ID</th>
                      <th>Academic Year</th>
                      <th>Semester</th>
                      <th>Date</th>
                      <th>Department / Course</th>
                      <th>Year & Section</th>
                      <th>Feedback Category</th>
                      <th>Book Availability</th>
                      <th>Borrowing Process</th>
                      <th>Returning Process</th>
                      <th>Staff Assistance</th>
                      <th>Cleanliness & Organization</th>
                      <th>Finding Resources</th>
                      <th>System Usefulness</th>
                      <th>Overall Service</th>
                      <th>Remarks</th>
                      <th>Date Submitted</th>
                    </tr>";

            foreach ($feedbacks as $row) {
              echo "<tr>";
              echo "<td>" . htmlspecialchars($row['feedback_id'] ?? '') . "</td>";
              echo "<td>" . htmlspecialchars($row['academic_year'] ?? '') . "</td>";
              echo "<td>" . htmlspecialchars($row['semester'] ?? '') . "</td>";
              echo "<td>" . htmlspecialchars($row['feedback_date'] ?? '') . "</td>";
              echo "<td>" . htmlspecialchars($row['branch'] ?? '') . "</td>";
              echo "<td>" . htmlspecialchars($row['section'] ?? '') . "</td>";
              echo "<td>" . htmlspecialchars($row['subject'] ?? '') . "</td>";
              echo "<td class='rating'>" . htmlspecialchars($row['ques1'] ?? '') . "</td>";
              echo "<td class='rating'>" . htmlspecialchars($row['ques2i'] ?? '') . "</td>";
              echo "<td class='rating'>" . htmlspecialchars($row['ques2ii'] ?? '') . "</td>";
              echo "<td class='rating'>" . htmlspecialchars($row['ques2iii'] ?? '') . "</td>";
              echo "<td class='rating'>" . htmlspecialchars($row['ques2iv'] ?? '') . "</td>";
              echo "<td class='rating'>" . htmlspecialchars($row['ques2v'] ?? '') . "</td>";
              echo "<td class='rating'>" . htmlspecialchars($row['ques3'] ?? '') . "</td>";
              echo "<td class='rating'>" . htmlspecialchars($row['ques4'] ?? '') . "</td>";
              echo "<td class='remarks'>" . htmlspecialchars($row['remarks'] ?? '') . "</td>";
              echo "<td>" . htmlspecialchars($row['created_at'] ?? '') . "</td>";
              echo "</tr>";
            }

            echo "</table>";
          } else {
            echo "<div class='no-data'>No library feedback records found.</div>";
          }
        }
      ?>

      <div class="button-row">
        <button class="refresh-btn" onclick="location.reload();">REFRESH</button>
        <a class="back-btn" href="adminpage.php">BACK</a>
      </div>
    </div>

    <div class="version">v2.0.0 | Feedback Details</div>
  </div>
</body>
</html>