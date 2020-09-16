namespace Commander.Models
{
    public class Command
    {
        // Id of the Command
        public int Id { get; set; }

        // How to use the command
        public string HowTo { get; set; }
        
        // Command Line
        public string Line { get; set; }

        // Platform the command is to be used
        public string Platform { get; set; }
    }
}