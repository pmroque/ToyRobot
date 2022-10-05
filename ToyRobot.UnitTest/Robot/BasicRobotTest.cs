using System.Threading.Tasks;
using ToyRobot.Robot;
using ToyRobot.RobotAction;
using Xunit;

namespace ToyRobot.UnitTest.Robot
{

    public class BasicRobotTest
    {
        [Fact]
        public async Task BasicRobot_Do_PlaceAction()
        {
            Action action = new PlaceAction("1", "2", "SOUTH");

            var robot = new BasicRobot();

            var position = await robot.TakeActionAsync(action);

            Assert.Equal(1, position.X);
            Assert.Equal(2, position.Y);
            Assert.Equal("SOUTH", position.Direction);
        }

        [Fact]
        public async Task BasicRobot_Do_MoveAction()
        {
            var currentPosition = new Position() { X = 0, Y = 0, Direction = "NORTH" };
            Action action = new MoveAction();

            var robot = new BasicRobot();
            robot.SavePosition(currentPosition);
            var position = await robot.TakeActionAsync(action);

            Assert.Equal(0, position.X);
            Assert.Equal(1, position.Y);
            Assert.Equal("NORTH", position.Direction);
        }

        [Fact]
        public async Task BasicRobot_Do_LeftAction()
        {
            var currentPosition = new Position() { X = 0, Y = 0, Direction = "NORTH" };
            Action action = new LeftAction();

            var robot = new BasicRobot();
            robot.SavePosition(currentPosition);
            var position = await robot.TakeActionAsync(action);

            Assert.Equal(0, position.X);
            Assert.Equal(0, position.Y);
            Assert.Equal("WEST", position.Direction);
        }

        [Fact]
        public async Task BasicRobot_Do_RightAction()
        {
            var currentPosition = new Position() { X = 0, Y = 0, Direction = "NORTH" };
            Action action = new RightAction();

            var robot = new BasicRobot();
            robot.SavePosition(currentPosition);
            var position = await robot.TakeActionAsync(action);

            Assert.Equal(0, position.X);
            Assert.Equal(0, position.Y);
            Assert.Equal("EAST", position.Direction);
        }
    }
}
