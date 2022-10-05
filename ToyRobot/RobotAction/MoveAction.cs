using System.Threading.Tasks;
using ToyRobot.Robot;
namespace ToyRobot.RobotAction
{

    public class MoveAction : Action
    {
        public MoveAction()
        {
            IsMovableAction = true;
        }

        public override async Task DoActionAsync(Position position)
        {
            switch (position.Direction)
            {
                case "NORTH": position.Y++; break;
                case "SOUTH": position.Y--; break;
                case "EAST": position.X++; break; 
                case "WEST": position.X--; break;               
            }
        }
    }
}
