using System.Threading.Tasks;
using ToyRobot.Robot;
namespace ToyRobot.RobotAction
{
    public class LeftAction : Action
    {
        public LeftAction()
        {
            IsMovableAction = true;
        }
        public override async Task DoActionAsync(Position position)
        {
            switch (position.Direction)
            {
                case Constant.NORTH: position.Direction = Constant.WEST; break;
                case Constant.SOUTH: position.Direction = Constant.EAST; break;
                case Constant.EAST: position.Direction = Constant.NORTH; break;
                case Constant.WEST: position.Direction = Constant.SOUTH; break;
            }
        }
    }
}
