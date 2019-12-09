using System.Net;
using tw_mars_rover.Plateau;
using tw_mars_rover.Rover;

namespace tw_mars_rover.Direction
{
    public class North : IDirection
    {
        private readonly IPlateau _plateau;

        public North(IPlateau plateau)
        {
            _plateau = plateau;
        }

        public IDirection TurnLeft()
        {
            return new West(_plateau);
        }

        public IDirection TurnRight()
        {
            return new East(_plateau);
        }

        public void Move()
        {
            _plateau.MoveYForward();
        }

  

        public override string ToString()
        {
            return "North";
        }
    }
}