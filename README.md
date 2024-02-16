### Day 1 - Today we are learning about Controllers and Routes

We are going to start by creating a Controller with Routes that Allow you to:
    1. Retrieves a list of Students - HttpGet
    2. Add a Student - HttpPost
    3. Deletes a Student - HttpDelete - don't hard delete
    4. Edit a Student - HttpPut

Give our Endpoints different Routes - Adding a specific path for the Endpoint

Pass data through Routes - to pass data through add /{parameter name} to the route for each parameter

### Day 2 - Today we are learning about Interfaces and Services

Dependency Injection - instead of having all of your functionality in one object, you split it up into other objects and inject it into your main one through an interface
    In human terms you can think of injection as importing, like we did with the API Keys in JS
    What's actually happening, is you are passing something through as a parameter for a constructor that saves a reference to a private field. 
        So when you use that field it locates and uses the original data

We are going to Create a Student Service and an Interface for that Service
    1. The Interface is what we will be injecting into our Controller
    2. The Service will handle all of the functionality of our Endpoints
    3. Connect the Interface with the Service


### Day 3 - Today we are learning about Database Connection and Implementation

Setting up SQLite DataBase
    1. Download SQLite
    2. Downloading the SQLite Browser - Option
    3. Create our Database
    4. Connect it to the API
    5. Implement it in the Student Service
    6. Update the Controller and Interface


### Day ?? - Today we are learning about Azure Databases 

Setting up Azure SQL Database
    1. Create the Database on Azure
    2. Add your IP to the Server Firewall
    3. Add the SQL Server Package
    4. Add the connection string
    5. Connect to the Database with the SQL VS Code extension




### Controllers

What is a Controller?
    A Controller is responsible for handling incoming requests from a client, examples 
    being a web browser or a mobile app, and making sure the correct response is returned

How does a Controller work?
    When a client makes a request to an API, it goes through a process of routing, where 
    the request is directed to a specific Controller, in the event that you have multiple, 
    based on the request URL and method. The Controller then interacts with other parts of
    the application to return the correct response

Why do we use Controllers?
    For a clean and organized file, where we can work on our Endpoints


### Interfaces

What is an Interface?
    An Interface usually refers to a set of rules that define how different parts of an 
    application should interact. It's essentially a contract that defines what methods or 
    functions a class, Service, should provide, without specifying how those functions 
    are used

How does an Interface work?
    An API Interface defines a set of methods that other parts of the application can use 
    to interact with a Service. The Interface specifies the names of the methods, the 
    parameters, and the value types they return. The Controller refers to the Interface 
    to understand what methods are available in a given Service and how to use them

Why do we use Interfaces?
    To hide the logic, to make testing easier, and make it reusable. 
    When building out API's the logic is tested before it's put into use, so once it works
    there is no need to mess with it. If there is a bug or you need test it, you can do so
    without effecting the other parts of the code.


### Services

What is a Service?
    A Service is a part of an application that is designed to perform specific tasks or 
    provide certain capabilities. It is a self-contained file that can be accessed and 
    utilized by other parts of the application

How does a Service work?
    A developer creates a Service that implements the Interface. This means they write 
    the actual logic for the methods outlined in the Interface. Different parts of the 
    application use the Interface to request and receive the desired Services

Why do we use Services?
    Instead of building huge applications where all functionality is tightly packed into 
    one file, Services allow us to break down the application into smaller, manageable 
    components. Each Service can focus on a specific task or feature.


### SQLite

What is SQLite?
    SQLite is a serverless Database management system that can be embedded into an application
    SQLite stores the whole Database into a single file on the local machine

### Database

What is a Database?
    A Database is like a structured, organized, and electronic filing system for storing and managing data. It's a place where you can store data in a way that makes it easy to retrieve, update and manage

### EF Core?
    EF Core is what's called an O.R.M. or Object Relation Manager
    Technical - Let us write C# Objects that will be translated over to Database Objects and handled on their own
    Normal - Lets us write C# code to manage our Database instead of going to a Database Browser

### Models

What is a Model?
    A Model is a representation of the data structure or objecrt. A template.
    The Model defines what Properties our Object will have but no the values

### Migration

What is a Migration?
    A migration is a snapshotof our C# code that EF Core will take and apply to your Database, when you make Database changes, thourhg your C# code, they will not be applied right away, you have to run a Migration

APIAdmin
APIPassword123