-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 16, 2026 at 11:20 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `common_library_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `lib_book_issue`
--

CREATE TABLE `lib_book_issue` (
  `id` int(11) NOT NULL,
  `member_id` int(11) NOT NULL,
  `ISBN` varchar(20) NOT NULL,
  `issue_date` date NOT NULL,
  `return_date` date NOT NULL,
  `status` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `lib_book_issue`
--

INSERT INTO `lib_book_issue` (`id`, `member_id`, `ISBN`, `issue_date`, `return_date`, `status`) VALUES
(1, 1, '26', '2026-05-04', '2026-05-07', 'Issued'),
(2, 1, '29', '2026-05-04', '2026-05-13', 'Issued'),
(3, 1, '26', '2026-05-05', '2026-05-06', 'Issued'),
(4, 1, '30', '2026-05-05', '2026-05-06', 'Issued'),
(5, 1, '31', '2026-05-05', '2026-05-06', 'Issued'),
(6, 1, '27', '2026-05-05', '2026-05-07', 'Issued'),
(7, 1, '33', '2026-05-13', '2026-05-14', 'Issued');

-- --------------------------------------------------------

--
-- Table structure for table `lms_books`
--

CREATE TABLE `lms_books` (
  `BookID` int(11) NOT NULL,
  `Title` varchar(100) DEFAULT NULL,
  `Author` varchar(100) DEFAULT NULL,
  `Genre` varchar(50) DEFAULT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `ISBN` varchar(50) DEFAULT NULL,
  `PublishedDate` date DEFAULT NULL,
  `Description` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `lms_books`
--

INSERT INTO `lms_books` (`BookID`, `Title`, `Author`, `Genre`, `Quantity`, `ISBN`, `PublishedDate`, `Description`) VALUES
(26, 'Inovation of Technology', 'NA', '1', 1, '1', '2026-04-26', 'Technology'),
(27, 'Technology', 'unknown', '1st', 1, '1', '2026-05-02', 'IT'),
(28, 'book1', 'admin', 'technology', 1, '12345', '2026-05-03', 'information'),
(29, 'Coding C++', 'Saligue', '1st', 1, '12321', '2026-05-04', 'for IT Student'),
(30, 'book2', 'sample', 'book', 1, '1245', '2026-05-05', 'samplebook2'),
(31, 'book3', 'book', 'sample', 1, '1234', '2026-05-05', 'booksample'),
(32, 'book5', 'null', 'sample', 1, '123', '2026-05-11', 'book5 sample'),
(33, 'C#', 'sample', 'WindowsFormApp', 1, '101', '2026-05-13', 'C# WindowsFormApp');

-- --------------------------------------------------------

--
-- Table structure for table `lms_user`
--

CREATE TABLE `lms_user` (
  `role` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `token` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `lms_user`
--

INSERT INTO `lms_user` (`role`, `email`, `password`, `token`) VALUES
('Admin', 'admin@gmail.com', '0192023a7bbd73250516f069df18b500', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `student_feedback`
--

CREATE TABLE `student_feedback` (
  `feedback_id` int(11) NOT NULL,
  `academic_year` varchar(20) DEFAULT NULL,
  `semester` varchar(20) DEFAULT NULL,
  `feedback_date` date DEFAULT NULL,
  `branch` varchar(50) DEFAULT NULL,
  `section` varchar(50) DEFAULT NULL,
  `subject` varchar(100) DEFAULT NULL,
  `ques1` int(11) DEFAULT NULL,
  `ques2i` int(11) DEFAULT NULL,
  `ques2ii` int(11) DEFAULT NULL,
  `ques2iii` int(11) DEFAULT NULL,
  `ques2iv` int(11) DEFAULT NULL,
  `ques2v` int(11) DEFAULT NULL,
  `ques3` int(11) DEFAULT NULL,
  `ques4` int(11) DEFAULT NULL,
  `remarks` text DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `student_feedback`
--

INSERT INTO `student_feedback` (`feedback_id`, `academic_year`, `semester`, `feedback_date`, `branch`, `section`, `subject`, `ques1`, `ques2i`, `ques2ii`, `ques2iii`, `ques2iv`, `ques2v`, `ques3`, `ques4`, `remarks`, `created_at`) VALUES
(3, '2026', 'Summer', '2026-04-25', 'BSIT', '2A', 'Book Availability', 5, 5, 5, 5, 5, 5, 5, 5, 'good', '2026-04-25 08:41:41'),
(4, '2026', 'Summer', '2026-04-25', 'BSIT', '2A', 'Book Availability', 5, 5, 5, 5, 5, 5, 5, 5, 'good', '2026-04-25 08:46:07'),
(5, '2026', 'Summer', '2026-04-26', 'BSIT', '3B', 'Borrowing Process', 5, 5, 5, 5, 5, 5, 5, 5, 'nice', '2026-04-26 10:05:14'),
(6, '2026', 'Summer', '2026-05-02', 'BSIT', '3A', 'Book Availability', 5, 5, 5, 5, 5, 5, 5, 5, 'nice', '2026-05-02 02:02:56'),
(7, '2026', '1st', '2026-05-16', 'BSIT', '3A', 'Book Availability', 5, 5, 5, 5, 5, 5, 5, 5, 'add more books', '2026-05-04 03:55:21'),
(8, '2025', '2nd', '2026-05-14', 'BSCS', '1A', 'Library Staff Service', 5, 5, 5, 5, 5, 5, 5, 5, 'good service', '2026-05-04 04:17:29'),
(9, '2026', 'Summer', '2026-05-05', 'BSIT', '3B', 'Borrowing Process', 5, 5, 5, 5, 5, 5, 5, 5, 'excellent service', '2026-05-05 05:35:56'),
(10, '2026', '2nd', '2026-05-05', 'BSED', '4A', 'Library Staff Service', 5, 5, 4, 5, 5, 4, 5, 5, 'good', '2026-05-05 09:09:25'),
(11, '2024', '1st', '2026-05-05', 'BSBA', '1A', 'Borrowing Process', 5, 4, 5, 5, 5, 5, 5, 5, 'nice', '2026-05-05 09:38:24'),
(13, '2026', 'Summer', '2026-05-11', 'BSIT', '1A', 'Book Availability', 5, 5, 5, 5, 5, 5, 5, 5, 'good', '2026-05-11 06:41:00'),
(15, '2026', 'Summer', '2026-05-13', 'BSIT', '4A', 'Book Availability', 5, 5, 5, 5, 5, 5, 5, 5, 'great', '2026-05-13 07:10:57');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `lib_book_issue`
--
ALTER TABLE `lib_book_issue`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `lms_books`
--
ALTER TABLE `lms_books`
  ADD PRIMARY KEY (`BookID`);

--
-- Indexes for table `lms_user`
--
ALTER TABLE `lms_user`
  ADD PRIMARY KEY (`email`);

--
-- Indexes for table `student_feedback`
--
ALTER TABLE `student_feedback`
  ADD PRIMARY KEY (`feedback_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `lib_book_issue`
--
ALTER TABLE `lib_book_issue`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `lms_books`
--
ALTER TABLE `lms_books`
  MODIFY `BookID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT for table `student_feedback`
--
ALTER TABLE `student_feedback`
  MODIFY `feedback_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
