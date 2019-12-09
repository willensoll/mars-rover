using System.Collections.Generic;

namespace tw_mars_rover
{
    public static class NavCommands
    {
        public static Dictionary<string, INavigation> List
        {
            get
            {
                var commands = new Dictionary<string, INavigation>
                {
                    {"M", new NavigateForward()},
                    {"L", new NavigateLeft()},
                    {"R", new NavigateRight()}
                };
                return commands;
            }
        }

    }
}