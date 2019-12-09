namespace tw_mars_rover.Plateau
{
    public interface IPlateau 
    {
        int CoordinateX { get; }
        int CoordinateY { get; }

        void MoveYForward();
        void MoveYBackward();
        void MoveXForward();
        void MoveXBackward();

        void SetStartCoordinates(string coords);
    }
}