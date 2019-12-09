using System.Collections.Generic;
using tw_mars_rover.Direction;
using tw_mars_rover.Plateau;

namespace tw_mars_rover.Rover
{
    public class MarsRover : IMarsRover
    {

        private readonly IPlateau _plateau;
        public IDirection Direction { get; private set; }
        
        public int CoordinateX => _plateau.CoordinateX;

        public int CoordinateY => _plateau.CoordinateY;

        public MarsRover(IPlateau plateau)
        {
            _plateau = plateau;
        }

        public void SetRoverDirection(List<string> param)
        {
            var direction = param[0].Split(" ")[2];
            
            Direction = direction switch
            {
                "N" => new North(_plateau),
                "E" => new East(_plateau),
                "S" => new South(_plateau),
                "W" => new West(_plateau),
                _ => Direction
            };
        }
        public void ExecuteCommands(List<string> commandString)
        {
            var commands = NavCommands.List;
            var commandParser = new NavCommandParser(commands);
            
            _plateau.SetStartCoordinates(commandString[0]);

            for (var index = 0; index < commandString[1].Length; index++)
            {
                var command = commandString[1][index].ToString();
                var commandToExecute = commandParser.ParseCommand(command);
                commandToExecute.Execute(this);
            }
        }

        public void TurnLeft()
        {
            Direction = Direction.TurnLeft();
        }

        public void TurnRight()
        {
            Direction = Direction.TurnRight();
        }

        public void Forward()
        {
            Direction.Move();
        }
    }
}