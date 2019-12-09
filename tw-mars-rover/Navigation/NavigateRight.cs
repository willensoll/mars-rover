using System;
using System.Windows.Input;
using tw_mars_rover.Rover;

namespace tw_mars_rover
{
    public class NavigateRight : INavigation
    {
        public void Execute(IMarsRover marsRover)
        {
            marsRover.TurnRight();
        }
    }
}