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
                Rationale = "An in-memory collection lives only in RAM while the app runs. The moment the process stops or restarts, that data is gone. A database stores data on disk (or a managed service), so it's still there the next time the application starts."
            }
        };
    }
}
