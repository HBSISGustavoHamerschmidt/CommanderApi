using System;
using System.Collections.Generic;
using System.Linq;
using Commander.Models;

namespace Commander.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;
        public SqlCommanderRepo(CommanderContext context) => _context = context;
        /****************/
        public bool SaveChanges() => (_context.SaveChanges()) >= 0;
        public IEnumerable<Command> GetAllCommands() => _context.Commands.ToList();
        public Command GetCommandById(int id) => _context.Commands.FirstOrDefault(p => p.Id == id);
        public void CreateCommand(Command cmd) =>
            _ = cmd != null ? _context.Commands.Add(cmd) : throw new ArgumentNullException(nameof(cmd));
        public void UpdateCommand(Command cmd)
        { // No need for implementation
        } 

        public void DeleteCommand(Command cmd) 
            => _ = cmd != null ? _context.Commands.Remove(cmd) : throw new ArgumentNullException(nameof(cmd));
    }
}