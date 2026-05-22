<?php
session_start();
ob_start();

if (isset($_POST['login'])) {

    $email = trim($_POST['email']);
    $password = trim($_POST['password']);

    $apiUrl = "http://localhost:3000/login";

    $data = array(
        "email" => $email,
        "password" => $password
    );

    $ch = curl_init($apiUrl);

    curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
    curl_setopt($ch, CURLOPT_POST, true);
    curl_setopt($ch, CURLOPT_HTTPHEADER, array(
        "Content-Type: application/json"
    ));
    curl_setopt($ch, CURLOPT_POSTFIELDS, json_encode($data));

    $response = curl_exec($ch);

    if (curl_errno($ch)) {
        echo "<script>
                alert('Cannot connect to API. Make sure server.js is running.');
                window.location.href='../admin.php';
              </script>";
        exit();
    }

    curl_close($ch);

    $result = json_decode($response, true);

    if ($result && isset($result['success']) && $result['success'] == true) {

        $_SESSION['login_user'] = $result['user']['email'];
        $_SESSION['role'] = $result['user']['role'];

        header("Location: ../adminpage.php");
        exit();

    } else {
        $message = isset($result['message']) ? $result['message'] : "Incorrect email or password";

        echo "<script>
                alert('$message');
                window.location.href='../admin.php';
              </script>";
        exit();
    }

} else {
    header("Location: ../admin.php");
    exit();
}
?>