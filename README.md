# Project Management System

## 🚀 Overview
This **Project Management System** is a Windows Forms application built using **C#**, **Entity Framework (EF)**, and **SQL Server**. It provides a structured way to manage projects, assign tasks to employees, and track overall progress.

## 🎯 Key Features
- ✅ **Project Management**: Create, edit, and track projects.
- ✅ **Task Assignment**: Assign tasks to employees with priorities and deadlines.
- ✅ **Employee Management**: Register employees and link them to projects.
- ✅ **Reports & Analytics**: View project progress and task completion rates.
- ✅ **Smart Filtering & Sorting**: Search and filter tasks based on priority, status, and deadlines.

## 🛠️ Technologies Used
- **C# WinForms** - For the user interface.
- **Entity Framework (EF)** - For database interactions.
- **SQL Server** - As the database management system.
- **LINQ** - For efficient querying.

## 📂 Project Structure
```
ProjectManagementSystem/
│── ProjectManagementSystem.sln    # Solution file  
│── Contexts/                       # Database context  
│   ├── PMSDbContext.cs                 # Main EF Core context  
│── Migrations/                      # EF Core migrations  
│   ├── 20250301010009_CreatingDB.cs     # Initial migration  
│   ├── 20250302142800_AddColumn.cs      # Column update migration  
│── Models/                          # Entity models  
│   ├── Employee.cs                      # Employee entity  
│   ├── Projects.cs                      # Projects entity  
│   ├── Reports.cs                       # Reports entity  
│   ├── TaskItem.cs                      # Task entity  
│── Resources/                        # UI & images  
│   ├── performance-tracking-icon.png  
│   ├── press-button.png  
│   ├── wallpaper6.jpg  
│── Forms/                            # Windows Forms UI  
│   ├── Employee.cs                      # Employee management form  
│   ├── EmployeeResult.cs                # Employee results display  
│   ├── Login.cs                         # Login form  
│   ├── Projects.cs                      # Project management form  
│   ├── Register.cs                      # Registration form  
│   ├── Reports.cs                       # Reports UI  
│   ├── ReportsForm.cs                   # Reports form  
│   ├── TaskResult.cs                    # Task result view  
│   ├── Tasks.cs                         # Task management form  
│── Program.cs                        # Entry point  
│── App.config                        # Configuration file  
│── README.md                         # Project documentation  
```

## 📥 Installation & Setup
### Prerequisites:
- Install **Visual Studio** with **.NET Framework**.
- Install **SQL Server** and **SQL Server Management Studio (SSMS)**.

### Steps to Run the Project:
1. **Clone the Repository**
   ```sh
   git clone https://github.com/mohammedhagggagg/Project-Management-System.git
   cd Project-Management-System
   ```

2. **Setup the Database**
   - Open **SQL Server Management Studio (SSMS)**.
   - In **Package Manager Console**, run the following commands:
     ```sh
     add-migration InitialCreate
     update-database
     ```
   - Ensure you have the required NuGet packages installed:
     - `Microsoft.EntityFrameworkCore.SqlServer`
     - `Microsoft.EntityFrameworkCore.Tools`
     - `Microsoft.EntityFrameworkCore.Design`
     - `LiveCharts` (for data visualization)

3. **Run the Application**
   - Open `ManagementSystem.sln` in **Visual Studio**.
   - Build and run the project.

## 📊 Reports & Analytics  

- **Employees** can generate reports to track:  
  - **Total tasks assigned and completed.**  
  - **Pending vs. completed tasks.**  
  - **Time taken to complete tasks.**  
  - **Their own activity and performance.** (Employees can only edit their own tasks)  

- **Admins** can generate comprehensive reports, including:  
  - **Overall project progress and completion rates.**  
  - **Employee performance and task efficiency.**  
  - **Comparative analysis of team members.**  
  - **Workload distribution and execution trends.**  

- **Graphical reports**:  
  - **Data visualization through charts and graphs.**  
  - **Printable reports with a structured format for better readability.**  

## 🔒 User Roles & Permissions  
| Role      | Permissions |
|-----------|------------|
| **Admin** | Full control: Manage users, projects, tasks, and generate reports. |
| **User**  | Limited access: Can read and edit assigned tasks only. |

🚀 Happy Coding! 😊

