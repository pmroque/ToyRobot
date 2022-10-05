using System.Threading.Tasks;
using ToyRobot.Robot;

namespace ToyRobot.RobotAction
{
    public abstract class Action
    {
       public bool IsMovableAction { get; set; }
       public string ActionMessage { get; set; }
       public abstract Task DoActionAsync(Position position);
    }
}
