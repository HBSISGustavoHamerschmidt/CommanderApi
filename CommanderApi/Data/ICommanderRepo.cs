using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        // Give me a list of all our command objects
        IEnumerable<Command> GetAllCommands();

        // Return me a single command based on an Id
        Command GetCommandById(int id);


    }
}