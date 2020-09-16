using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command {Id = 0, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Kettle & Pan"},
                new Command {Id = 1, HowTo = "Cute Bread", Line = "Get a Knife", Platform = "Knife & Chopping Board"},
                new Command {Id = 2, HowTo = "Make cup of tea", Line = "Place Teabag in Cup", Platform = "Kettle & Cup"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Kettle & Pan" };
        }
    }
}