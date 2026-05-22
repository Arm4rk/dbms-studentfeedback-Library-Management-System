<?php
ob_start();
require 'config.php';

$data = array(
    "year" => $_POST['year'],
    "sem" => $_POST['sem'],
    "date" => $_POST['date'],
    "branch" => $_POST['branch'],
    "section" => $_POST['section'],
    "subject" => $_POST['subject'],
    "ques1" => $_POST['ques1'],
    "ques-2i" => $_POST['ques-2i'],
    "ques-2ii" => $_POST['ques-2ii'],
    "ques-2iii" => $_POST['ques-2iii'],
    "ques-2iv" => $_POST['ques-2iv'],
    "ques-2v" => $_POST['ques-2v'],
    "ques3" => $_POST['ques3'],
    "ques4" => $_POST['ques4'],
    "remarks" => $_POST['remarks']
);

$apiUrl = $API_BASE_URL . "/api/feedback";

$ch = curl_init($apiUrl);

curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
curl_setopt($ch, CURLOPT_POST, true);
curl_setopt($ch, CURLOPT_HTTPHEADER, array(
    "Content-Type: application/json"
));
curl_setopt($ch, CURLOPT_POSTFIELDS, json_encode($data));

$response = curl_exec($ch);

if (curl_errno($ch)) {
    echo '<script>alert("Cannot connect to API. Make sure server.js is running."); location.replace(document.referrer);</script>';
    exit();
}

curl_close($ch);

$result = json_decode($response, true);

if ($result && isset($result["status"]) && $result["status"] == "success") {
    echo '<script>alert("Thank you for the feedback."); location.replace(document.referrer);</script>';
} else {
    echo '<script>alert("Failed to submit feedback."); location.replace(document.referrer);</script>';
}
?>