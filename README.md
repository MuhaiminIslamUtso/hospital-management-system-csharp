# Hospital Management System

A Windows desktop application developed using **C#, Windows Forms, and Microsoft SQL Server** to support common hospital administration and reception workflows. The system brings together patient records, staff administration, appointments, room bookings, medical tests, billing, payroll, and financial reporting in one application.

## Project Overview

The Hospital Management System is a desktop-based software project built to practise C# application development, object-oriented programming, event-driven user interfaces, and relational database integration.

The application provides separate navigation flows for administrators and receptionists, along with forms for managing hospital records and day-to-day operations.

## Features

### 1. Login and Role-Based Navigation
- Login interface with User ID and password fields.
- Supports separate navigation for **Admin** and **Receptionist** user types.
- Provides access to the relevant dashboard after a successful login.
- Includes input checks for required login fields.

### 2. Doctor Management
- Add and view doctor records.
- Update and delete existing doctor information.
- Search doctor records.
- Display doctor details in a data grid.
- Generate a doctor license ID based on existing database records.
- Store information such as name, joining date, age, gender, salary, specialization, emergency contact, email, working time, and appointment capability.

### 3. Nurse Management
- Add, view, search, update, and delete nurse records.
- Generate a nurse license ID based on existing database records.
- Display nurse information for administrative management.

### 4. Employee Management
- Add new employee or staff records.
- View, search, update, and delete employee information.
- Refresh the displayed staff records.
- Maintain employee details in the database.

### 5. Patient Management
- Register and maintain patient information.
- View patient records.
- Search for existing patients.
- Update or delete patient information.
- Validate required patient inputs before saving.

### 6. Appointment Management
- Load and select doctors and patients from the database.
- Create and manage appointment records.
- Work with appointment status and cost fields.
- View appointment information through the application interface.

### 7. Room Management and Booking
- Add, view, search, update, and delete room records.
- Select a room type and booking duration.
- Check room availability for a selected date range.
- Check existing active bookings for overlapping dates.
- Calculate booking costs and applicable discounts through the booking workflow.
- Create room booking records for patients.

### 8. Medical Test Management
- Add, view, search, update, and delete medical test records.
- Select a patient and one or more tests.
- Calculate the total cost of selected tests.
- Create and view test orders.
- Display paid and unpaid test orders.
- Continue to the relevant billing and receipt workflow.

### 9. Billing and Payment Records
- View patient-related billing information.
- Work with appointment, room booking, and medical test order charges.
- Record payment information and payment status through the application's billing workflows.
- Search and refresh billing records.
- Generate and print payment slips or receipts for supported workflows.

**Note:** The project contains payment-related application workflows. It should not be assumed to provide a production payment gateway or process real card transactions.

### 10. Staff Absence Management
- Select a staff category, including doctor, nurse, or employee.
- Select a staff member and record an absence date.
- Check for duplicate absence entries for the same staff member and date.
- View absence history.

### 11. Salary and Payroll Management
- Process monthly salary records for doctors, nurses, and employees.
- Calculate doctor salary deductions based on recorded absences.
- Store monthly salary details.
- View salary records and calculate salary totals.

### 12. Financial Balance and Expenses
- View financial records and balance-related information.
- Filter records by date.
- Add manual expense entries.
- Refresh displayed financial data.
- Navigate to salary information.
- Print supported financial information.

### 13. Financial Charts and Summary
- Calculate recorded income from payment records.
- Calculate expenses from salary records and manual expenses.
- Display income-versus-expense charts.
- Switch between supported bar and pie chart views.
- Calculate and display profit or loss from the recorded totals.
- Export the chart as a PNG image.

### 14. Interactive Chatbot Assistant
The application includes a chatbot interface with guided workflows for selected hospital operations, including:

- Patient lookup by ID.
- Patient admission and information collection.
- Displaying available doctor information.
- Appointment-related interaction.
- Medical test selection.
- Room selection and booking-related interaction.
- Patient history.
- Billing and payment-related interaction.
- Email verification or payment email steps implemented in the chatbot workflow.

The chatbot is an application-level interactive assistant. Its presence alone does not imply that it uses a large language model or an external AI service.

### 15. Receipts and Printing
- Display receipt information in a dedicated receipt form.
- Print supported receipts and payment slips.
- Export financial charts as PNG images.

## Technology Stack

| Technology | Purpose |
|---|---|
| C# | Application logic |
| Windows Forms (WinForms) | Desktop user interface |
| .NET Framework 4.7.2 | Application target framework |
| Microsoft SQL Server | Relational database |
| ADO.NET / SQL Client | Database access and queries |
| Microsoft Visual Studio | Development environment |
| SQL Server Management Studio (SSMS) | Optional database administration tool |

## Project Structure

```text
Hospital_Management_System/
├── Database/
│   └── SQLQuery1.sql
├── Hospital_Management_System/
│   ├── Properties/
│   ├── Resources/
│   ├── Absence.cs
│   ├── AdDoctor.cs
│   ├── AdEmployee.cs
│   ├── AdHome.cs
│   ├── AdNurse .cs
│   ├── AdRoom.cs
│   ├── AdTest.cs
│   ├── AmountBarChart.cs
│   ├── Balance.cs
│   ├── Chatbot.cs
│   ├── FrmReceipt.cs
│   ├── LogingFrom.cs
│   ├── RcAppointment.cs
│   ├── RcBilling.cs
│   ├── RcHome.cs
│   ├── RcPatient.cs
│   ├── RcRoom.cs
│   ├── RcTest.cs
│   ├── Salary.cs
│   ├── User.cs
│   ├── Program.cs
│   ├── App.config
│   ├── packages.config
│   └── Hospital Management System.csproj
├── .gitignore
└── README.md
```

*Note: Visual Studio designer files (`.Designer.cs`), resource files (`.resx`), and other project files are also part of the application. The exact repository contents may vary.*

## Prerequisites

Before running the application, install or configure:

1. **Windows** with support for the required .NET Framework.
2. **Microsoft Visual Studio** with the .NET desktop development workload.
3. **.NET Framework 4.7.2** or the required targeting/developer pack.
4. **Microsoft SQL Server** with a database configured for this application.
5. **SQL Server Management Studio (SSMS)**, if needed for database setup and administration.
6. The NuGet dependencies required by the project.

## Getting Started

### 1. Clone the Repository

Open PowerShell or a terminal and run:

```bash
git clone https://github.com/MuhaiminIslamUtso/hospital-management-system-csharp.git
```

### 2. Open the Solution

1. Open Microsoft Visual Studio.
2. Open the solution file named `Hospital Management System.sln` from the application project directory.
3. Allow Visual Studio to load the project and restore any required NuGet dependencies.

### 3. Configure the Database

The application uses Microsoft SQL Server. Database setup must match the schema and connection settings expected by the application.

1. Set up a local SQL Server instance.
2. Identify or create the database containing the required tables and relationships.
3. If using the included database files, configure and attach them to your SQL Server instance using the appropriate SQL Server procedure.
4. Verify that the required tables and data are available.
5. Update the connection string in `App.config` to match your own SQL Server instance and database.

The current project configuration contains a machine-specific SQL Server connection string. **Do not assume it will work on another computer without changes.**

The `Database/SQLQuery1.sql` file contains an `Absence` table definition; it is not, by itself, a complete database initialization script for every module.

### 4. Restore Dependencies

Use Visual Studio's NuGet package restoration features to restore the dependencies referenced by the project. Resolve any missing-reference issues before building.

### 5. Build and Run

1. Select the appropriate build configuration in Visual Studio.
2. Build the solution.
3. Resolve any compilation or dependency errors.
4. Confirm the database connection is correct.
5. Run the application and test the available workflows.

## Database and Configuration Notes

- The application relies on SQL Server tables for its hospital records and workflows.
- The database schema must match the queries used by the application.
- Connection strings are machine-specific and should be updated for each development environment.
- Do not publish real patient records, account passwords, private email credentials, or other sensitive data.
- Use test data and a local development database when demonstrating the project.

## Security and Usage Disclaimer

This project is intended for educational and portfolio purposes. It has not been presented as a production-ready hospital information system.

Before using a system like this in a real healthcare environment, additional work would be required to review authentication, password storage, authorization, input validation, audit logging, patient-data privacy, payment handling, backups, and operational reliability.

## Learning Outcomes

This project demonstrates practical work with:

- C# and object-oriented desktop application development.
- Windows Forms and event-driven programming.
- SQL Server integration using SQL queries and ADO.NET.
- CRUD (Create, Read, Update, Delete) operations.
- Form navigation and user workflows.
- Date-based room availability checks.
- Salary calculations and absence-based deductions.
- Financial calculations, charting, and export.
- Receipt generation and printing.

## Author

**Muhaimin Islam Utso**

GitHub: [MuhaiminIslamUtso](https://github.com/MuhaiminIslamUtso)

---

*This repository is intended for educational, learning, and portfolio purposes.*
