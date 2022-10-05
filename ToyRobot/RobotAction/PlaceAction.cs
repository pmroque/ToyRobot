using System.Threading.Tasks;
using ToyRobot.Robot;
namespace ToyRobot.RobotAction
{
    public class PlaceAction : Action
    {      

        readonly int X;
        readonly int Y;
        readonly string Direction;
        public PlaceAction(string x, string y, string direction)
        {
            X = int.Parse(x);
            Y = int.Parse(y);
            Direction = direction;
            IsMovableAction = true;

        }
        public override async Task DoActionAsync(Position position)
        {
            position.X = this.X;
            position.Y = this.Y;
            position.Direction = this.Direction.ToUpper();
        }
    }
}
