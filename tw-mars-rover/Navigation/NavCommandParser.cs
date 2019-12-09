using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace tw_mars_rover
{
    public class NavCommandParser
    {
        private readonly Dictionary<string, INavigation> _commands;

        public NavCommandParser(Dictionary<string, INavigation> commands)
        {
            _commands = commands;
        }

        public INavigation ParseCommand(string command)
        {
            return _commands.ContainsKey(command) ? _commands[command] : new NavigationNotFound();
        }
    }
}