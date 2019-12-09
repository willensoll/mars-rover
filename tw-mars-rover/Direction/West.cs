using tw_mars_rover.Plateau;
using tw_mars_rover.Rover;

namespace tw_mars_rover.Direction
{
    public class West : IDirection
    {
        private readonly IPlateau _plateau;
        public West(IPlateau plateau)
        {
            _plateau = plateau;
       }

        public IDirection TurnLeft()
        {
            return new South(_plateau);
            
        }

        public IDirection TurnRight()
        {
            return new North(_plateau);
        }
        
        public void Move()
        {
            _plateau.MoveXBackward();
        }
        

        public override string ToString()
        {
            return "West";
        }
    }
}