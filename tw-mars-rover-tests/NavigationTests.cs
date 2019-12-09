using System.Collections.Generic;
using NUnit.Framework;
using tw_mars_rover;

namespace t_mars_rover_tests
{
    [TestFixture]
    public class NavigationTests
    {
        private Dictionary<string, INavigation> _navCommands;
        
        [SetUp]
        public void Setup()
        {
            _navCommands = NavCommands.List;
        }

        [Test]
        public void get_correct_command_to_turn_left()
        {
            var commandParser = new NavCommandParser(_navCommands);
            var command = commandParser.ParseCommand("L");
            Assert.That(command, Is.TypeOf(typeof(NavigateLeft)));
        }
 
        [Test]
        public void get_correct_command_to_turn_right()
        {
            var commandParser = new NavCommandParser(_navCommands);
            var command = commandParser.ParseCommand("R");
            Assert.That(command, Is.TypeOf(typeof(NavigateRight)));
        }
 
        [Test]
        public void get_correct_command_to_move_forward()
        {
            var commandParser = new NavCommandParser(_navCommands);
            var command = commandParser.ParseCommand("M");
            Assert.That(command, Is.TypeOf(typeof(NavigateForward)));
        }

        [Test]
        public void navigation_not_found_command_triggered()
        {
            var commandParser = new NavCommandParser(_navCommands);     
            var command = commandParser.ParseCommand("FOO");              
            Assert.That(command, Is.TypeOf(typeof(NavigationNotFound)));   
        }
    }

}