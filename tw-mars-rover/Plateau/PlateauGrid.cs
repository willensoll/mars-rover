using System;
using tw_mars_rover.Direction;

namespace tw_mars_rover.Plateau
{ 
    public class PlateauGrid : IPlateau
    {
        public int CoordinateX { get; private set; }
        public int CoordinateY { get; private set; }

        private readonly int _gridY;

        private readonly int _gridX;
        
        public PlateauGrid(string gridSize)
        {
            var splitAxis = gridSize.Split(" ");
            _gridY = Int32.Parse(splitAxis[0]);
            _gridX = Int32.Parse(splitAxis[1]);
        }

        public void SetStartCoordinates(string coords)
        {
            var splitCoords = coords.Split(" ");
            CoordinateX = Int32.Parse(splitCoords[0]);
            CoordinateY = Int32.Parse(splitCoords[1]);
        }

        public void MoveYForward()
        { 
            if (CoordinateY < _gridY) CoordinateY++;
            else Console.WriteLine($"CoordinateY out of bounds");
        }

        public void MoveYBackward()
        {
            if (CoordinateY > 0) CoordinateY--;
            else Console.WriteLine($"CoordinateY out of bounds");
        }

        public void MoveXForward()
        {
            if (CoordinateX < _gridX) CoordinateX++;
            else Console.WriteLine($"CoordinateX out of bounds");
        }

        public void MoveXBackward()
        {
            if (CoordinateX > 0) CoordinateX--;
            else Console.WriteLine($"CoordinateX out of bounds");
        }
    }
}