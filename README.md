[README_OnlineShoppingAutomation.md](https://github.com/user-attachments/files/32254796/README_OnlineShoppingAutomation.md)
# Online Shopping Automation — ASP.NET MVC 5

<p align="center">
  A dynamic commercial automation and e-commerce management application built with <strong>ASP.NET MVC 5</strong>, <strong>Entity Framework 6 Code First</strong> and <strong>SQL Server</strong>. The project combines a public storefront, customer panel and administration panel in a single data-driven web application.
</p>

<p align="center">
  <img src="https://img.shields.io/badge/ASP.NET-MVC%205-512BD4?logo=dotnet&logoColor=white" alt="ASP.NET MVC 5" />
  <img src="https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?logo=dotnet&logoColor=white" alt=".NET Framework 4.7.2" />
  <img src="https://img.shields.io/badge/Entity%20Framework-6.5.1-512BD4" alt="Entity Framework 6" />
  <img src="https://img.shields.io/badge/SQL%20Server-Database-CC2927?logo=microsoftsqlserver&logoColor=white" alt="SQL Server" />
  <img src="https://img.shields.io/badge/Bootstrap-5.2.3-7952B3?logo=bootstrap&logoColor=white" alt="Bootstrap" />
  <img src="https://img.shields.io/badge/jQuery-3.4.1-0769AD?logo=jquery&logoColor=white" alt="jQuery" />
</p>

---

## About the Project

**Online Shopping Automation** is a full dynamic web project developed with ASP.NET MVC 5. It models the operational side of a commercial store and separates the application into three main experiences:

- **Public / Storefront Panel** — product presentation and general website content
- **Customer Panel** — customer account information and purchase history
- **Admin Panel** — management of products, categories, customers, employees, departments, sales, invoices and application statistics

The project goes beyond basic CRUD operations by combining relational data, LINQ queries, dashboard statistics, charts, pagination, authentication, SQL Server triggers and stored procedures, and database-driven business operations.

---

## Core Features

### Admin Panel

- Dynamic administration dashboard
- Category management
- Product management
- Product search and pagination
- Product stock and price management
- Product activation / soft-delete workflow
- Customer / seller management
- Department management
- Employee management
- Sales transaction management
- Invoice and invoice-item management
- Sales and customer history views
- Gallery management
- To-do / task overview
- Dashboard cards and statistical widgets
- Table-based management interfaces

### Customer Panel

- Customer registration
- Customer login
- Forms Authentication
- Session-based customer information
- Customer profile area
- Customer-specific order / sales history
- Separate customer layout and navigation

### Storefront / Web Panel

- Dynamic MVC views
- Product listing
- Product detail structure
- Public home, about and contact pages
- Reusable layouts and partial views
- Responsive Bootstrap-based interface
- Template integration and customization

---

## Dashboard & Reporting

The administration dashboard uses LINQ and Entity Framework queries to generate live business statistics, including:

- Total customers
- Total products
- Total employees
- Total categories
- Total product stock
- Number of distinct brands
- Low-stock product count
- Most expensive product
- Least expensive product
- Product counts by category
- Most frequently used brand
- Best-selling product
- Total sales revenue
- Daily sales count
- Daily sales revenue
- Customer distribution by city
- Employee distribution by department
- Product distribution by brand

The reporting interface is supported by **Chart.js**, dashboard widgets and dynamic tables.

---

## Database & Data Access

The project uses **Microsoft SQL Server** with **Entity Framework 6 Code First** for database management.

### Database Concepts Used

- Code First database design
- Entity Framework migrations
- LINQ queries
- Entity Framework queries
- Relational tables and navigation properties
- One-to-many relationships
- Data annotations and model validation
- SQL Server triggers
- Stored procedures
- Database-side automation
- Aggregate queries and reporting

### Main Entities

| Entity | Responsibility |
|---|---|
| **Admin** | Administrator accounts and roles |
| **Seller / Customer** | Customer information, login and purchase history |
| **Category** | Product categories |
| **Product** | Product, brand, price, stock, image and status information |
| **Department** | Company departments |
| **Employee** | Employee and department information |
| **SalesLog** | Product, customer and employee-linked sales transactions |
| **Bill** | Invoice / billing header information |
| **InvoiceItem** | Individual invoice line items |
| **Expense** | Commercial expense records |
| **Detail** | Product detail content |
| **ToDo** | Dashboard task records |

### Main Relationships

- **Category → Products**
- **Department → Employees**
- **Product → Sales Logs**
- **Customer → Sales Logs**
- **Employee → Sales Logs**
- **Bill → Invoice Items**

---

## MVC Structure

The application follows the ASP.NET MVC separation of concerns:

- **Models** define entities, validation rules and Entity Framework relationships.
- **Views** use Razor syntax to render dynamic data and reusable UI components.
- **Controllers** handle requests, CRUD operations, filtering, authentication and business flows.
- **Layouts** provide separate shared interfaces for the public site, admin panel and customer panel.
- **Partial Views** are used for reusable components and modular page sections.

---

## Technology Stack

### Backend

- C#
- ASP.NET MVC 5.2.9
- .NET Framework 4.7.2
- Entity Framework 6.5.1
- Entity Framework Code First
- LINQ
- Razor View Engine
- Forms Authentication
- Session Management

### Database

- Microsoft SQL Server
- Entity Framework Migrations
- SQL Triggers
- Stored Procedures
- Relational Database Design

### Frontend

- HTML5
- CSS3
- JavaScript
- Bootstrap 5.2.3
- jQuery 3.4.1
- Razor Views
- Partial Views
- AdminLTE
- Responsive UI components

### UI & Data Visualization

- Chart.js
- DataTables
- Dashboard widgets
- Statistic cards
- Dynamic tables
- PagedList / PagedList.Mvc

---

## Additional Implemented Concepts

- Layout control and reusable page structures
- Controller-based request handling
- Model binding
- Data annotations and server-side validation
- Dropdown lists populated from related database tables
- Search and filtering
- Pagination
- Soft-delete / status-based record management
- Dynamic dashboard queries
- Relational navigation properties
- Customer and administrator authentication flows
- Ready-made template integration and customization
- CSS and Bootstrap customization
- Dynamic commercial web application development
- Publishing / deployment workflow for a completed MVC web application

---

## Project Purpose

This project was developed to demonstrate how a complete commercial automation system can be built from scratch with ASP.NET MVC 5. It combines application architecture, relational database management, administrative operations, customer-facing functionality, reporting and database automation within a practical end-to-end web project.
