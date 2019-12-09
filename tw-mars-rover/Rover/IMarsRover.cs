using tw_mars_rover.Direction;
using tw_mars_rover.Plateau;

namespace tw_mars_rover.Rover
{
    public interface IMarsRover
    {
        void TurnLeft();
        void TurnRight();
        void Forward();
    }
}