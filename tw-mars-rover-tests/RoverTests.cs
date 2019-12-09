using System.Collections.Generic;
using NUnit.Framework;
using tw_mars_rover.Direction;
using tw_mars_rover.Plateau;
using tw_mars_rover.Rover;

namespace t_mars_rover_tests
{
    [TestFixture]
    public class MarsRoverTests
    {
        private IPlateau _plateau;

        [SetUp]
        public void Setup()
        {
            _plateau = new PlateauGrid("5 5");
        }

        [Test]
        public void Rover_starts_at_correct_direction_on_input()
        {
         
            var commands = new List<string> {"1 2 N", "LMLMLMLMM"};

            var rover = new MarsRover(_plateau);
            rover.SetRoverDirection(commands);
            
            Assert.That(rover.Direction, Is.TypeOf<North>());
        }

        [Test]
        public void Rover_ends_on_correct_test_case_on_input()
        {    
        var commands = new List<string> {"1 2 N", "LMLMLMLMM"};
            
            var rover = new MarsRover(_plateau);
            rover.SetRoverDirection(commands);
            rover.ExecuteCommands(commands);
            Assert.That(rover.Direction, Is.TypeOf<North>());
            Assert.That(rover.CoordinateX, Is.EqualTo(1));
            Assert.That(rover.CoordinateY, Is.EqualTo(3));
        }
        
        [Test]
        public void Rover_ends_on_correct_test_case_on_input2()
        {    
            var commands = new List<string> {"3 3 E", "MMRMMRMRRM"};
            
            var rover = new MarsRover(_plateau);
            rover.SetRoverDirection(commands);
            rover.ExecuteCommands(commands);
            Assert.That(rover.Direction, Is.TypeOf<East>());
            Assert.That(rover.CoordinateX, Is.EqualTo(5));
            Assert.That(rover.CoordinateY, Is.EqualTo(1));
        }

        
        [Test]
        public void when_rover_is_created_and_turns_right_direction_is_east()
        {
            var commands = new List<string> {"1 2 N", "LMLMLMLMM"};

            var rover = new MarsRover(_plateau);
            rover.SetRoverDirection(commands);
            rover.TurnLeft();
            Assert.That(rover.Direction, Is.TypeOf<West>());
        }

        [Test]
        public void when_rover_is_created_is_facing_north_and_nav_fwd_rover_will_be_at_coords_0_1()
        {
            var commands = new List<string> {"0 0 N", "LMLMLMLMM"};

            var rover = new MarsRover(_plateau);
            rover.SetRoverDirection(commands);
            rover.Forward();
            Assert.That(rover.CoordinateX, Is.EqualTo(0));
            Assert.That(rover.CoordinateY, Is.EqualTo(1));
        }
        
        [Test]
        public void when__rover_is_created_turn_right_and_move_rover_will_be_at_coords_1_0()
        {
            var commands = new List<string> {"0 0 N", "LMLMLMLMM"};

            var rover = new MarsRover(_plateau);
            rover.SetRoverDirection(commands);

            rover.TurnRight();
            rover.Forward();
            Assert.That(rover.CoordinateX, Is.EqualTo(1));
            Assert.That(rover.CoordinateY, Is.EqualTo(0));            
        }
        
        [Test]
        public void when_rover_is_created_and_move_so_that_facing_south_and_move_coordinates_will_be_0_1()
        {
            var commands = new List<string> {"0 0 N", "LMLMLMLMM"};

            var rover = new MarsRover(_plateau);
            rover.SetRoverDirection(commands);

            rover.Forward();
            rover.Forward();
            rover.TurnRight();
            rover.TurnRight();
            Assert.That(rover.Direction, Is.TypeOf<South>());
            rover.Forward();
            Assert.That(rover.CoordinateX, Is.EqualTo(0));
            Assert.That(rover.CoordinateY, Is.EqualTo(1));
        }
 
        [Test]
        public void when_the_rover_is_created_and_move_so_that_facing_west_and_move_coordinates_will_be_1_0()
        {
            var commands = new List<string> {"0 0 N", "LMLMLMLMM"};

            var rover = new MarsRover(_plateau);     
            rover.SetRoverDirection(commands);
            rover.TurnRight();
            rover.Forward();
            rover.Forward();
            rover.TurnRight();
            rover.TurnRight();
            Assert.That(rover.Direction, Is.TypeOf<West>());
            rover.Forward();
            Assert.That(rover.CoordinateX, Is.EqualTo(1));
            Assert.That(rover.CoordinateY, Is.EqualTo(0));
        }
    }
}