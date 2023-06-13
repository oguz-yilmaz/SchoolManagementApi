## School Management Restful API Example

This School Management project is an example of a REST API developed using ASP.NET Core. 
It follows a layered architecture pattern and is well-organized into separate projects within a solution. 
Here are the details:

### REST API:
**REST API** is a set of rules and conventions for building web services. It uses HTTP methods like GET, POST, PUT, DELETE to operate over resources, which are essentially various entities relevant to the service (like Students, Courses, Grades, etc. in this case). JSON is usually the format for sending and receiving data in REST APIs. They are stateless, meaning each request from client to server must contain all of the information needed to understand and process the request.

### Projects in the Solution:
**Entities**: This project contains the data models or entities that represent the domain of the school management system, like Student, Course, Grade, and Teacher. These classes are simple POCOs (Plain Old CLR Objects) with properties representing fields in the database.

**Repositories**: This project contains the Repository classes. The Repository Pattern is a popular way to achieve separation of concerns in an application by encapsulating the logic needed to access data sources. It centralizes data logic or business logic and service domain interfaces. Here, a generic Repository<TEntity> class provides standard CRUD operations, and specific repositories like StudentRepository can add operations specific to the entity.

**ServiceContracts**: This project contains the interfaces for the service layer. Defining service behavior through interfaces allows different implementations and makes it easier to switch between them. It also supports dependency injection to replace the actual services with mocks/stubs during testing.

**Services**: This project implements the services defined in ServiceContracts. It provides an abstraction over the data access layer, encapsulates the business logic, and makes the controllers in the API thin and maintainable. The services call the repositories to interact with the database.

**WebApi**: This is the ASP.NET Core project where controllers reside. They handle HTTP requests and responses. They use the services to perform operations and return HTTP responses.

### Some example features used:
**Asynchronous Programming (async/await)**: The async/await pattern is used heavily in the services and controllers to improve scalability by freeing up threads to serve more requests while waiting for I/O operations like database calls to complete.

**Dependency Injection (DI)**: DI is used to provide the services and repositories needed by different parts of the application. This is done through the constructors of the classes, which ask for dependencies as parameters, and the framework automatically provides them.

**Entity Framework Core**: The project uses EF Core, a popular Object-Relational Mapping (ORM) tool, to interact with the database. This simplifies data access code by allowing you to work with database data in terms of C# objects.

**Data Annotations**: The Entity classes use Data Annotations for model validation and to configure the EF Core model.

**Fluent API**: Fluent API in Entity Framework Core is used to configure the model classes and their relationships. This is done in the OnModelCreating method in the DbContext.

**Middleware**: Middleware components handle requests and responses and can be chained together in a pipeline in an ASP.NET Core application.

**Exception Handling**: Proper exception handling ensures that meaningful responses are returned when errors occur.

**Route and Query Parameters**: Route parameters are used for actions that require input to perform operations, while query parameters can be used to filter, sort, or page data.

**LINQ (Language Integrated Query)**: LINQ is used to query data from the database using C#, providing a more intuitive and type-safe way to work with data.

The API exposes endpoints for managing students, teachers, courses, exams, and grades keeping the structure easy.