Brgy 11 MALASAKIT Clinic System
A comprehensive Clinic Management System designed to streamline appointment scheduling, patient records management, and service reporting for Barangay 11's health clinic.
📋 Project Overview
This Customer Relationship Management (CRM) system digitizes and automates the clinic's daily operations, replacing manual processes with an efficient, secure, and user-friendly desktop application.
Key Features

Patient Management - Centralized patient records and information
Appointment & Scheduling - Efficient booking system to minimize conflicts and waiting times
Services Management - Track and monitor clinic services rendered
Staff & User Management - Role-based access control for clinic staff
Reporting & Analytics - Generate insights on patient visits, services, and trends
Feedback Collection - Patient satisfaction monitoring and service evaluation

🛠️ Technology Stack

Framework: C# .NET WinForms
IDE: Visual Studio 2022
Database: SQL Server (SSMS)
Visualization: Chart Controls

🚀 Getting Started
Prerequisites

Visual Studio 2022 or later
SQL Server Management Studio (SSMS)
.NET Framework (version specified in project)

Installation Steps

Clone the Repository

bash   git clone https://github.com/your-repo/brgy11-malasakit-clinic.git
   cd brgy11-malasakit-clinic

Set Up the Database

Open SQL Server Management Studio (SSMS)
Connect to your local SQL Server instance
Create a new database named MalasakitClinicDB
Locate the database script file in the /Database folder
Execute the script to create tables and seed initial data



sql   -- Run the provided SQL script
   USE master;
   CREATE DATABASE MalasakitClinicDB;
   GO
   USE MalasakitClinicDB;
   GO
   -- Execute the rest of the schema script

Configure Database Connection

Open the project in Visual Studio 2022
Navigate to the configuration file (e.g., App.config or appsettings.json)
Update the connection string with your SQL Server details:



   Server=YOUR_SERVER_NAME;Database=MalasakitClinicDB;Trusted_Connection=True;

Build and Run

Open the solution file (.sln) in Visual Studio
Restore NuGet packages if prompted
Build the solution (Ctrl + Shift + B)
Run the application (F5)



📊 Target Users

Barangay Health Staff
Clinic Administrators
Patients (for appointment booking and feedback)

🎯 Project Objectives

Streamline appointment management and reduce waiting times
Improve patient record accuracy and accessibility
Enhance service monitoring through analytics
Facilitate patient feedback collection
Ensure data security and integrity

🤝 Contributors
This project was developed by:

Janrel Francisco - Front-End Developer
Huey Chum Hibaler - Back-End Developer
Lebron James Pathay - QA / Security Specialist
Albert Melendres - Data Analyst / Project Manager

📄 License
This project is developed as an academic requirement for IT13L course.
