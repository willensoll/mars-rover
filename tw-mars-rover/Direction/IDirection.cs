using tw_mars_rover.Plateau;
using tw_mars_rover.Rover;

namespace tw_mars_rover.Direction
{
    public interface IDirection
    {
        IDirection TurnLeft();
        IDirection TurnRight();
        void Move();
        
        
    }
}