using NUnit.Framework;
using tw_mars_rover.Direction;
using tw_mars_rover.Plateau;

namespace t_mars_rover_tests
{
    [TestFixture]
    public class DirectionTests
    {
        private IPlateau _plateau;

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void left_from_north_is_west()
        {
            var direction = new North(_plateau);
            var newdirection = direction.TurnLeft();
            Assert.That(newdirection, Is.TypeOf<West>());
        }

        [Test]
        public void right_from_north_is_east()
        {
            var direction = new North(_plateau);
            var newdirection = direction.TurnRight();
            Assert.That(newdirection, Is.TypeOf<East>());
        }
        [Test]
        public void left_from_east_is_north()
        {
            var direction = new East(_plateau);
            var newdirection = direction.TurnLeft();
            Assert.That(newdirection, Is.TypeOf<North>());
        }
        [Test]
        public void right_from_east_is_south()
        {
            var direction = new East(_plateau);
            var newdirection = direction.TurnRight();
            Assert.That(newdirection, Is.TypeOf<South>());
        }
        [Test]
        public void left_from_south_is_west()
        {
            var direction = new South(_plateau);
            var newdirection = direction.TurnLeft();
            Assert.That(newdirection, Is.TypeOf<East>());
        }
        
        [Test]
        public void right_from_south_is_east()
        {
            var direction = new South(_plateau);
            var newdirection = direction.TurnRight();
            Assert.That(newdirection, Is.TypeOf<West>());
        }
        
        [Test]
        public void left_from_west_is_south()
        {
            var direction = new West(_plateau);
            var newdirection = direction.TurnLeft();
            Assert.That(newdirection, Is.TypeOf<South>());
        }
        
        [Test]
        public void right_from_west_is_north()
        {
            var direction = new West(_plateau);
            var newdirection = direction.TurnRight();
            Assert.That(newdirection, Is.TypeOf<North>());
        }
    }
}