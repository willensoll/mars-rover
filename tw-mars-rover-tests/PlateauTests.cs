using NUnit.Framework;
using tw_mars_rover.Plateau;

namespace t_mars_rover_tests
{
    [TestFixture]
    public class PlateauTests
    {
        [Test]
        public void rover_will_start_at_coordinates_specified_on_init()
        {
            var plateauGrid = new PlateauGrid("5 5");
            plateauGrid.SetStartCoordinates("1 2");
            Assert.That(plateauGrid.CoordinateX, Is.EqualTo(1));
            Assert.That(plateauGrid.CoordinateY, Is.EqualTo(2));
        }

        [Test]
        public void plateau_coordy_does_not_go_out_of_bounds_fwd()
        {
            var plateauGrid = new PlateauGrid("1 0");
            plateauGrid.MoveYForward();
            plateauGrid.MoveYForward();
            Assert.AreEqual(1, plateauGrid.CoordinateY);
        }
        
        [Test]
        public void plateau_coordx_does_not_go_out_of_bounds_fwd()
        {
            var plateauGrid = new PlateauGrid("0 1");
            plateauGrid.MoveXForward();
            plateauGrid.MoveXForward();
            Assert.AreEqual(1, plateauGrid.CoordinateX);
        }
        
        [Test]
        public void plateau_coordy_does_not_go_out_of_bounds_bwd()
        {
            var plateauGrid = new PlateauGrid("1 0");
            plateauGrid.MoveYBackward();
            Assert.AreEqual(0, plateauGrid.CoordinateY);
        }
        
        [Test]
        public void plateau_coordx_does_not_go_out_of_bounds_bwd()
        {
            var plateauGrid = new PlateauGrid("0 1");
            plateauGrid.MoveXBackward();;
            Assert.AreEqual(0, plateauGrid.CoordinateX);
        }
    }
}