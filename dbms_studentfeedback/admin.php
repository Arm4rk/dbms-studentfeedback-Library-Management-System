<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="UTF-8" />
    <title>Library Feedback Admin Login</title>

    <style>
      body {
        margin: 0;
        font-family: Arial, sans-serif;
        background: rgb(128, 64, 64);
        min-height: 100vh;
        display: flex;
        justify-content: center;
        align-items: center;
      }

      .login-form {
        width: 380px;
        background-color: white;
        padding: 35px;
        border-radius: 18px;
        box-shadow: 0 10px 30px rgba(0, 0, 0, 0.3);
      }

      .login-form h2 {
        text-align: center;
        margin-bottom: 25px;
        color: rgb(128, 64, 64);
      }

      label {
        font-weight: bold;
        color: rgb(128, 64, 64);
      }

      input[type="email"],
      input[type="password"] {
        width: 100%;
        padding: 12px;
        margin-top: 8px;
        border: 1px solid #cbd5e1;
        border-radius: 8px;
        font-size: 15px;
        box-sizing: border-box;
      }

      input[type="email"]:focus,
      input[type="password"]:focus {
        outline: none;
        border-color: rgb(128, 64, 64);
        box-shadow: 0 0 0 3px rgba(128, 64, 64, 0.15);
      }

      .submit-form {
        text-align: center;
        margin-top: 20px;
      }

      #login {
        width: 100%;
        background-color: rgb(128, 64, 64);
        color: white;
        border: none;
        padding: 13px;
        border-radius: 8px;
        font-size: 16px;
        font-weight: bold;
        cursor: pointer;
      }

      #login:hover {
        background-color: rgb(105, 50, 50);
      }

      .note {
        text-align: center;
        font-size: 13px;
        color: #64748b;
        margin-top: 18px;
      }
    </style>
  </head>

  <body>
    <div class="login-form">
      <h2>Library Feedback Admin Login</h2>

      <form action="php/checklogin.php" method="POST">
        <label>
          Email
          <input
            type="email"
            id="email"
            placeholder="Enter admin email"
            name="email"
            required
          />
        </label>

        <br /><br />

        <label>
          Password
          <input
            type="password"
            id="password"
            placeholder="Enter admin password"
            name="password"
            required
          />
        </label>

        <div class="submit-form">
          <input type="submit" id="login" name="login" value="Login" />
        </div>
      </form>

      <p class="note">Admin access for Library Feedback System</p>
    </div>
  </body>
</html>