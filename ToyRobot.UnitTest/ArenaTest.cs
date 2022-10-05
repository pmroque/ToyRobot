using System.Threading.Tasks;
using ToyRobot.Exceptions;
using ToyRobot.RobotAction;
using Xunit;

namespace ToyRobot.UnitTest
{
    public class ArenaTest
    {
        [Fact]
        public async Task Arena_TakeSigleAction_With_NoRobot_Return_NoRobotException()
        {
            Action action = new PlaceAction("1", "2", "SOUTH");

            var arena = new Arena(5,5);

            try
            {
                var result = await arena.TakeSigleActionAsync("PLACE 0,0,NORTH");
            }
            catch (NoRobotException ex)
            {

                Assert.Equal("There is no robot in the Arena.", ex.Message);
            }         
           
        }

    }
}
