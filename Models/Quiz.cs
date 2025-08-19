public class Quiz
{
    public int Id { get; set; }
    public string Title { get; set; }          // "VHDL FIFO Buffer Design"
    public string Description { get; set; }    // Problem statement
    public string Difficulty { get; set; }     // Easy/Medium/Hard
    public string CodeTemplate { get; set; }   // Starter code (SystemVerilog/VHDL)
    public string TestCases { get; set; }      // JSON input/output pairs
}