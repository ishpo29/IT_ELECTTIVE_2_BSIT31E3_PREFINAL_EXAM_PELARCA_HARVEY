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

        };
    }
}
