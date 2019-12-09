using System;
using System.Windows.Input;
using tw_mars_rover.Rover;

namespace tw_mars_rover
{
    public class NavigationNotFound : INavigation
    {
        public void Execute(IMarsRover marsRover)
        {
            Console.WriteLine("Navigation command not found");
        }
    }
}