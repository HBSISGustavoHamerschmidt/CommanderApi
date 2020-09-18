using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        // Save Changes
        bool SaveChanges();

        // Give me a list of all our command objects
        IEnumerable<Command> GetAllCommands();

        // Return me a single command based on an Id
        Command GetCommandById(int id);
        
        // Create a new command and add it to the database
        void CreateCommand(Command cmd);

        // Update a currently existing Command on database
        void UpdateCommand(Command cmd);


        // Delete single command based on an Id
        void DeleteCommand(Command cmd);
    }
}