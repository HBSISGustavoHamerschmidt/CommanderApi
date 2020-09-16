using System.ComponentModel.DataAnnotations;

namespace Commander.Models
{
    public class Command
    {
        // Id of the Command
        [Key]
        public int Id { get; set; } 

        // How to use the command
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        // Command Line
        [Required]
        public string Line { get; set; }

        // Platform the command is to be used
        [Required]
        public string Platform { get; set; }
    }
}