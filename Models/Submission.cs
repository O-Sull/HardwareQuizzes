public class Submission
{
    public int Id { get; set; }
    public string UserCode { get; set; }      // User's submitted code
    public bool IsCorrect { get; set; }
    public int QuizId { get; set; }            // Foreign key
    public Quiz Quiz { get; set; }             // Navigation property
}