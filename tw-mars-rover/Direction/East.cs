using tw_mars_rover.Plateau;

namespace tw_mars_rover.Direction
{
    public class East : IDirection
    {
        private readonly IPlateau _plateau;

        public East(IPlateau plateau)
        {
            _plateau = plateau;
        }

        public IDirection TurnLeft()
        {
            return new North(_plateau);
        }

        public IDirection TurnRight()
        {
            return new South(_plateau);
        }
        
        public void Move()
        {
            _plateau.MoveXForward();
        }
        
        public override string ToString()
        {
            return "East";
        }
    }
}