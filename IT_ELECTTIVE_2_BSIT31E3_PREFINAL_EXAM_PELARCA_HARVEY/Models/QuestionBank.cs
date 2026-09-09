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

        };
    }
}
