using System.Threading.Tasks;
using ToyRobot.RobotAction;

namespace ToyRobot.Robot
{
    public interface IRobot
    {
        Task<Position> TakeActionAsync(Action action);
        void SavePosition(Position position);
    }
}