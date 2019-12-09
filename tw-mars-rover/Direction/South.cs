using tw_mars_rover.Plateau;
using tw_mars_rover.Rover;

namespace tw_mars_rover.Direction
{
    public class South : IDirection
    {

        private readonly IPlateau _plateau;
        public South(IPlateau plateau)
        {
            _plateau = plateau;
        }

        public IDirection TurnLeft()
        {
            return new East(_plateau);
        }

        public IDirection TurnRight()
        {
            return new West(_plateau);
        }

        public void Move()
        {
             _plateau.MoveYBackward();
        }

        public override string ToString()
        {
            return "South";
        }
    }
}