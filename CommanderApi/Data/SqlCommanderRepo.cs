﻿using System.Collections.Generic;
using System.Linq;
using Commander.Models;

namespace Commander.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;
        public SqlCommanderRepo(CommanderContext context) => _context = context;
        public IEnumerable<Command> GetAllCommands() => _context.Commands.ToList();
        public Command GetCommandById(int id) => _context.Commands.FirstOrDefault(p => p.Id == id);
    }
}