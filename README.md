# To-Do-List-My-Ass

Description

A web-based to-do-list app where users can add, edit, and delete daily objectives. The front-end is built with Angular, and the back-end uses ASP.NET Core.

## Tech Stack

- ASP.NET Core (Web API)
- Angular

## Requirements

- Design RESTful API endpoints for ToDo operations (Hint: Refer to ASP.NET Core Web API docs: https://docs.microsoft.com/aspnet/core/web-api/)
- Implement CRUD operations in both API and Angular (Hint: Use Angular HttpClient for HTTP requests)
- Manage UI state in Angular using component properties or RxJS (Hint: Use RxJS BehaviorSubject or component state variables)
- Validate user input in Angular forms (Hint: Import ReactiveFormsModule in AppModule)
- Handle and display errors from HTTP requests (Hint: Use RxJS catchError in services and show error messages in UI)
- Write unit tests for API controllers and Angular components (Hint: Use xUnit for .NET and Jasmine/Karma for Angular)
- Follow best practices like dependency injection and logging (Hint: Inject ILogger<T> via constructor)

## Installation

### Prerequisites

- .NET SDK
- Node.js & npm

### Back-end Setup

1. Navigate to the `server` directory:

   cd server

2. Restore and build the project:

   dotnet restore
   dotnet build

3. Configure environment variables or update `appsettings.json`:

   - ConnectionStrings: update `DefaultConnection` for your database
   - ASPNETCORE_ENVIRONMENT (e.g., Development)

### Front-end Setup

1. Navigate to the `client` directory:

   cd ../client

2. Install dependencies:

   npm install

3. Update API base URL in `src/environments/environment.ts` if needed

## Usage

### Running the API

In the `server` directory, run:

   dotnet run

### Running the Angular App

In the `client` directory, run:

   npm start

Then open your browser at `http://localhost:4200`.

## Implementation Steps

1. Initialize the ASP.NET Core Web API project (`dotnet new webapi`).
2. Define the `ToDoItem` model and data context (EF Core or in-memory store).
3. Create `ToDoController` with CRUD endpoints and inject `ILogger<ToDoController>`.
4. Configure services in `Program.cs` (dependency injection for DbContext, logging, CORS).
5. Write xUnit tests for the API controllers.
6. Scaffold the Angular project (`ng new client --routing`).
7. Generate ToDo service and components (`ng generate service todo`, `ng generate component todo-list`, etc.).
8. Implement Reactive Forms in `TodoFormComponent` and import `ReactiveFormsModule`.
9. Use `HttpClient` in `TodoService` to call the API and manage state with `BehaviorSubject`.
10. Handle errors with `catchError` in the service and display messages in components.
11. Write Jasmine/Karma unit tests for services and components.
12. Test end-to-end CRUD flows and validate UI behavior.

## API Endpoints

- GET /api/todos
- GET /api/todos/{id}
- POST /api/todos
- PUT /api/todos/{id}
- DELETE /api/todos/{id}