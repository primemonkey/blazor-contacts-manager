
# Technical Specification for Blazor Contacts Manager Application

## 1. Application Overview

The Blazor Contacts Manager is a web application built with Blazor WebAssembly for the frontend and ASP.NET Core for the backend. It allows users to manage a list of contacts with CRUD (Create, Read, Update, Delete) operations. Microsoft SQL Server is used as the database.

## 2. Libraries Used

### Frontend Libraries
- **Blazor WebAssembly**: Framework for building interactive web UIs using C#.
- **Blazored.LocalStorage**: Local storage abstraction for Blazor applications.
- **Bootstrap**: CSS framework for styling and responsive design.

### Backend Libraries
- **ASP.NET Core**: Framework for building the web API.
- **Entity Framework Core**: ORM for database operations.
- **Microsoft.EntityFrameworkCore.SqlServer**: SQL Server provider for Entity Framework Core.

## 3. Application Structure

### 3.1 Frontend (Blazor WebAssembly)

#### `Program.cs`

- Configures the Blazor WebAssembly host, sets up services like `HttpClient` and `Blazored.LocalStorage`.

#### `App.razor`

- Sets up routing and rendering for the Blazor application using `<Router>` and `<RouteView>`.

#### `Pages/Contacts.razor`

- Displays a list of contacts, provides links for viewing, editing, and deleting contacts.
- Key Method: `OnInitializedAsync()`: Fetches the list of contacts from the backend.

#### `Pages/CreateContact.razor`

- Provides a form to create a new contact.
- Key Method: `HandleValidSubmit()`: Sends the new contact data to the backend for creation.

#### `Pages/EditContact.razor`

- Provides a form to edit an existing contact.
- Key Method: `OnInitializedAsync()`: Loads the contact details for editing.

#### `Pages/ContactDetails.razor`

- Displays detailed information about a specific contact.

#### `Pages/DeleteContact.razor`

- Provides a confirmation interface for deleting a contact.

### 3.2 Backend (ASP.NET Core)

#### `Controllers/ContactController.cs`

- Exposes RESTful API endpoints for contact operations.
- Key Methods:
  - `GetContacts()`: Returns a list of all contacts.
  - `GetContact(int id)`: Returns a contact by ID.
  - `CreateContact(Contact contact)`: Creates a new contact.
  - `UpdateContact(int id, Contact contact)`: Updates an existing contact.
  - `DeleteContact(int id)`: Deletes a contact by ID.

#### `Services/ContactService.cs`

- Contains business logic for managing contacts.
- Key Methods:
  - `GetContacts()`: Retrieves a list of contacts from the database.
  - `GetContact(int id)`: Retrieves a specific contact by ID.
  - `CreateContact(Contact contact)`: Adds a new contact to the database.
  - `UpdateContact(Contact contact)`: Updates contact information.
  - `DeleteContact(int id)`: Removes a contact from the database.

#### `Data/ApplicationDbContext.cs`

- Represents the database context for Entity Framework Core.
- Key Property: `Contacts`: DbSet representing the Contacts table in the database.

#### `Program.cs`

- Configures services and middleware for the application.
- Key Methods:
  - `ConfigureServices(IServiceCollection services)`: Registers services, including `ApplicationDbContext`, `ContactService`, and adds support for controllers.
  - `Configure(IApplicationBuilder app, IWebHostEnvironment env)`: Sets up the request pipeline, including HTTPS redirection, static file serving, and routing.

