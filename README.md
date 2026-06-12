  Student Management System 🎓

A Windows Forms desktop application for university administration.  
Developed in C# with WinForms as a portfolio pet project.

> Based on the "Network City" prototype concept.

---

 Features

 Authentication
- Single login/password (demo version)

 Student Management

| Status | Form |
|--------|------|
| Full-time students | Form3 |
| Part-time students | Form4 |
| Expelled students | Form5 |
| Academic leave | Form6 |

 Smart Behaviors
- Transfer students between statuses (full-time ↔ part-time)
- Move students to/from academic leave
- Reinstate expelled students

 Special Feature: Archive
- Archive button shows MessageBox: *"Insufficient privileges. Please contact the archivist."*
- Demonstrates role-based access thinking

 Theme Support
- Default theme (brown)
- Light theme (white background, light buttons)

 Print Functionality
- Print student lists with configurable settings

---

 Forms Overview

| Form | Purpose |
|------|---------|
| Form1 | Login (demo credentials) |
| Form2 | Main menu |
| Form3 | Full-time students list |
| Form4 | Part-time students list |
| Form5 | Expelled students list |
| Form6 | Academic leave students list |

---

 Architecture

### Data Storage
Data is stored in-memory within the code (collections, lists). No external database required — perfect for demonstrating C# logic without database complexity.

### Global Data Class
The application uses a static class to manage student data across all forms.

---

 Screenshots

 Main Menu
![Main Menu](screenshots/main-menu.png)

 Full-time Students List
![Full-time Students](screenshots/fulltime-students.png)

 Moving a Student (Full-time → Part-time)
![Transfer demo](screenshots/transfer-demo.gif)

---

 Technologies

| Technology | Description |
|------------|-------------|
| C# | Main programming language |
| Windows Forms | Desktop UI framework |
| .NET | Runtime environment |
| Visual Studio | IDE |

---

 How to Run

1. Install **Visual Studio** (2022 Community or later)
2. Clone this repository
3. Open the `.sln` solution file
4. Press `F5` to build and run

 Demo Credentials
- Login: `Pelipenko1090` 
- Password: `owA876` 

---

 Project Structure

student-management-system/
├── screenshots/
│ ├── main-menu.png
│ ├── fulltime-students.png
│ └── transfer-demo.gif
├── Form1.cs
├── Form2.cs
├── Form3.cs
├── Form4.cs
├── Form5.cs
├── Form6.cs
├── Global.cs (или ваш класс с данными)
├── Program.cs
├── Properties/
├── .gitignore
└── README.md

Future Improvements

- [ ] Move data from in-memory to SQLite database
- [ ] Add search functionality
- [ ] Export student lists to Excel
- [ ] Add real role-based access (admin, archivist)


Author
Alina
Student / Junior C# Developer

GitHub: Alina-Kompanii

Project: student-management-system

This is a learning / pet project created for portfolio purposes.
Built with ❤️ for educational administration
