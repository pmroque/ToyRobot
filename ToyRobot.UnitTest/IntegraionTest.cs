using System.Threading.Tasks;
using ToyRobot.Exceptions;
using Xunit;

namespace ToyRobot.UnitTest
{
    public class IntegrationTest
    {
        [Fact]
        public async Task Integration_1st_Senario()
        {
            var arena = new Arena(5, 5);

            try
            {
                await arena.TakeSigleActionAsync("PLACE 0,0,NORTH");
                await arena.TakeSigleActionAsync("MOVE");
                var result = await arena.TakeSigleActionAsync("REPORT");
                Assert.Equal("0,1,NORTH", result);

            }
            catch (NoRobotException ex)
            {

                Assert.Equal("There is no robot in the Arena.", ex.Message);
            }
        }


        [Fact]
        public async Task Integration_2nd_Senario()
        {
            var arena = new Arena(5, 5);

            try
            {
                await arena.TakeSigleActionAsync("PLACE 0,0,NORTH");
                await arena.TakeSigleActionAsync("LEFT");
                var result = await arena.TakeSigleActionAsync("REPORT");
                Assert.Equal("0,0,WEST", result);

            }
            catch (NoRobotException ex)
            {

                Assert.Equal("There is no robot in the Arena.", ex.Message);
            }
        }

        [Fact]
        public async Task Integration_3rd_Senario()
        {
            var arena = new Arena(5, 5);

            try
            {
                await arena.TakeSigleActionAsync("PLACE 1,2,EAST");
                await arena.TakeSigleActionAsync("MOVE");
                await arena.TakeSigleActionAsync("MOVE");
                await arena.TakeSigleActionAsync("LEFT");
                await arena.TakeSigleActionAsync("MOVE");
                var result = await arena.TakeSigleActionAsync("REPORT");
                Assert.Equal("3,3,NORTH", result);

            }
            catch (NoRobotException ex)
            {

                Assert.Equal("There is no robot in the Arena.", ex.Message);
            }

        }
    }

}