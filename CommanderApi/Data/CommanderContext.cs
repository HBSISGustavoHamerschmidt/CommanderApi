using Commander.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {
        }

        // We want to represent our command Objects down to our database as a DBSet, and it will be called Commands
        public DbSet<Command> Commands { get; set; }

    }
}