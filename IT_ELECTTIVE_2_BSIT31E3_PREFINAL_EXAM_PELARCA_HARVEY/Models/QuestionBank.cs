namespace IT_ELECTTIVE_2_BSIT31E3_PREFINAL_EXAM_PELARCA_HARVEY.Models
{
    public static class QuestionBank
    {
        public static List<QuestionRecord> All = new List<QuestionRecord>
        {
            new QuestionRecord
            {
                Number = 1,
                Topic = "Databases vs in-memory storage",
                Prompt = "What is the main problem solved by using a database instead of an in-memory collection?",
                ChoiceA = "It makes C# code shorter",
                ChoiceB = "It prevents the application from restarting",
                ChoiceC = "It allows data to persist after the application stops",
                ChoiceD = "It removes the need for MVC",
                CorrectLetter = 'C',
                
            },
            new QuestionRecord
            {
                Number = 2,
                Topic = "EF Core approaches",
                Prompt = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
                ChoiceA = "Code-First",
                ChoiceB = "Database-First",
                ChoiceC = "Model-First",
                ChoiceD = "Controller-First",
                CorrectLetter = 'B'
            },
            new QuestionRecord
            {
                Number = 3,
                Topic = "Purpose of EF Core",
                Prompt = "What is the primary purpose of Entity Framework Core?",
                ChoiceA = "To create HTML pages automatically",
                ChoiceB = "To replace the MVC Controller",
                ChoiceC = "To map objects in code to relational database data",
                ChoiceD = "To replace the C# compiler",
                CorrectLetter = 'C'
            },
            new QuestionRecord
            {
                Number = 4,
                Topic = "DbContext role",
                Prompt = "Which EF Core component is primarily responsible for communicating with the database?",
                ChoiceA = "DbContext",
                ChoiceB = "DbSetView",
                ChoiceC = "ControllerContext",
                ChoiceD = "RazorContext",
                CorrectLetter = 'A'
            },
            new QuestionRecord
            {
                Number = 5,
                Topic = "EF Core scaffold command",
                Prompt = "What does the following command primarily do?\n\ndotnet ef dbcontext scaffold \"ConnectionString\" Microsoft.EntityFrameworkCore.SqlServer -o Models",
                ChoiceA = "Deletes the database",
                ChoiceB = "Creates a new MVC project",
                ChoiceC = "Generates EF Core models and a DbContext from an existing database",
                ChoiceD = "Starts the MVC application",
                CorrectLetter = 'C'
            },
            new QuestionRecord
            {
                Number = 6,
                Topic = "Connection string location",
                Prompt = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
                ChoiceA = "Program.cs only",
                ChoiceB = "appsettings.json",
                ChoiceC = "Index.cshtml",
                ChoiceD = "Student.cs",
                CorrectLetter = 'B'
            },
            new QuestionRecord
            {
                Number = 7,
                Topic = "Entity relationships",
                Prompt = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
                ChoiceA = "One-to-One",
                ChoiceB = "One-to-Many",
                ChoiceC = "Many-to-Many",
                ChoiceD = "Many-to-One only",
                CorrectLetter = 'B'
            },
                        new QuestionRecord
            {
                Number = 8,
                Topic = "Foreign keys",
                Prompt = "In the following example, what is SectionId?\n\npublic int SectionId { get; set; }\npublic Section Section { get; set; }",
                ChoiceA = "Primary key of Student",
                ChoiceB = "Foreign key referencing Section",
                ChoiceC = "Navigation property",
                ChoiceD = "Database connection string",
                CorrectLetter = 'B'
            },
            new QuestionRecord
            {
                Number = 9,
                Topic = "Navigation properties",
                Prompt = "What is the purpose of a navigation property such as public Section Section { get; set; }?",
                ChoiceA = "It stores the database password",
                ChoiceB = "It represents a relationship to another entity",
                ChoiceC = "It creates a new database",
                ChoiceD = "It validates the student's name",
                CorrectLetter = 'B'
            },
            new QuestionRecord
            {
                Number = 10,
                Topic = ".Include() behavior",
                Prompt = "What does .Include() generally allow EF Core to do?",
                ChoiceA = "Delete the Section table",
                ChoiceB = "Load related Section data together with Students",
                ChoiceC = "Create a new Student",
                ChoiceD = "Validate Student input",
                CorrectLetter = 'B'
            },
            new QuestionRecord
            {
                Number = 11,
                Topic = "ViewModels",
                Prompt = "Why might a ViewModel be used when displaying Student and Section information?",
                ChoiceA = "To replace the database",
                ChoiceB = "To combine or shape the data specifically needed by the view",
                ChoiceC = "To automatically create database tables",
                ChoiceD = "To prevent controllers from using LINQ",
                CorrectLetter = 'B'
            },
            new QuestionRecord
            {
                Number = 12,
                Topic = "Include() with LINQ",
                Prompt = "Consider this query:\n\nvar students = _context.Students.Include(s => s.Section).ToList();\n\nWhat is the main benefit of Include(s => s.Section)?",
                ChoiceA = "It loads the related Section navigation property",
                ChoiceB = "It creates a Section object manually",
                ChoiceC = "It removes the foreign key",
                ChoiceD = "It prevents the query from accessing the database",
                CorrectLetter = 'A'
            },
                        new QuestionRecord
            {
                Number = 13,
                Topic = "Client-side validation",
                Prompt = "Which type of validation occurs in the browser before a request is sent to the server?",
                ChoiceA = "Database-level validation",
                ChoiceB = "Client-side validation",
                ChoiceC = "Server-side validation",
                ChoiceD = "EF Core migration validation",
                CorrectLetter = 'B'
            },
            new QuestionRecord
            {
                Number = 14,
                Topic = "Server-side validation",
                Prompt = "Why is server-side validation still necessary if client-side validation exists?",
                ChoiceA = "Client-side validation can be bypassed",
                ChoiceB = "Client-side validation automatically modifies the database",
                ChoiceC = "Server-side validation only works with SQLite",
                ChoiceD = "Client-side validation cannot display messages",
                CorrectLetter = 'A'
            },
                new QuestionRecord
            {
                Number = 15,
                Topic = "Uniqueness rules",
                Prompt = "A school requires every student to have a unique Student Number. Which rule best represents this requirement?",
                ChoiceA = "Student Number should always be nullable",
                ChoiceB = "Student Number should be unique",
                ChoiceC = "Student Number should always be the same",
                ChoiceD = "Student Number should contain only spaces",
                CorrectLetter = 'B'
            },
                        new QuestionRecord
            {
                Number = 16,
                Topic = "Database-level constraints",
                Prompt = "Which is the best reason for having a database-level unique constraint on StudentNumber?",
                ChoiceA = "It protects data integrity even if application-level validation is bypassed",
                ChoiceB = "It makes Razor Views render faster",
                ChoiceC = "It removes the need for a Controller",
                ChoiceD = "It automatically creates a ViewModel",
                CorrectLetter = 'A'
            },
                        new QuestionRecord
            {
                Number = 17,
                Topic = "try...catch in controllers",
                Prompt = "What is the purpose of a try...catch block in a controller?",
                ChoiceA = "To create navigation properties",
                ChoiceB = "To catch and handle exceptions that may occur during execution",
                ChoiceC = "To generate database tables",
                ChoiceD = "To perform client-side validation",
                CorrectLetter = 'B'
            },
                        new QuestionRecord
            {
                Number = 18,
                Topic = "Exception-handling middleware",
                Prompt = "Which middleware is commonly used in ASP.NET Core for centralized exception handling?",
                ChoiceA = "UseDatabase()",
                ChoiceB = "UseExceptionHandler()",
                ChoiceC = "UseValidationHandler()",
                ChoiceD = "UseMvcDatabase()",
                CorrectLetter = 'B'
            },
                        new QuestionRecord
            {
                Number = 19,
                Topic = "Handling missing records",
                Prompt = "A user requests /Student/999, but Student 999 does not exist. What would be the most appropriate response?",
                ChoiceA = "Display the student's information anyway",
                ChoiceB = "Display a Not Found (404) response/page",
                ChoiceC = "Delete Student 999",
                ChoiceD = "Create Student 999 automatically",
                CorrectLetter = 'B'
            },
        };
    }
}
