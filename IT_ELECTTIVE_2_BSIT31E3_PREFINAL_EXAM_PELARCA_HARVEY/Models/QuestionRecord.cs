namespace IT_ELECTTIVE_2_BSIT31E3_PREFINAL_EXAM_PELARCA_HARVEY.Models
{
    public class QuestionRecord
    {
        public int Number { get; set; }
        public string Topic { get; set; } = "";
        public string Prompt { get; set; } = "";
        public string ChoiceA { get; set; } = "";
        public string ChoiceB { get; set; } = "";
        public string ChoiceC { get; set; } = "";
        public string ChoiceD { get; set; } = "";
        public char CorrectLetter { get; set; }
        public string Rationale { get; set; } = "";
    }
}
