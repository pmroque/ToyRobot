using System.Threading.Tasks;
using ToyRobot.Robot;
namespace ToyRobot.RobotAction
{
    public class RightAction : Action
    {
        public RightAction()
        {
            IsMovableAction = true;
        }
        public override async Task DoActionAsync(Position position)
        {
            switch (position.Direction)
            {
                case Constant.NORTH: position.Direction = Constant.EAST; break;
                case Constant.SOUTH: position.Direction = Constant.WEST; break;
                case Constant.EAST: position.Direction = Constant.SOUTH; break;
                case Constant.WEST: position.Direction = Constant.NORTH; break;
            }
        }
    }
}
