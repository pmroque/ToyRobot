using System.Threading.Tasks;
using ToyRobot.RobotAction;

namespace ToyRobot.Robot
{
    public class BasicRobot : IRobot
    {
        private Position Position { get; set; } = new Position();

        public async  Task<Position> TakeActionAsync(Action action)
        {
            var newPosition = Position.Clone();
            await action.DoActionAsync(newPosition);
            return newPosition;
        }

        public void SavePosition(Position position)
        {
            this.Position = position;
        }

    }
}
