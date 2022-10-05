using System.Collections.Generic;
using System.Threading.Tasks;
using ToyRobot.Exceptions;
using ToyRobot.Robot;
using ToyRobot.RobotAction;

namespace ToyRobot
{
    public class Arena
    {
        public readonly int X;
        public readonly int Y;
        private List<IRobot> Robots = new List<IRobot>();

        public Arena(int x, int y)
        {
            X = x;
            Y = y;
        }


        public async Task<string> TakeSigleActionAsync(string action, int robotIndex = 0)
        {
            CheckIfRobotAvailable();

            RobotAction.Action robotAction = new ActionParser().Parse(action);
            var position = await Robots[robotIndex].TakeActionAsync(robotAction);

            SaveRobotPosition(robotIndex, position);

            return robotAction.ActionMessage;
        }

        private void SaveRobotPosition(int robotIndex, Position position)
        {
            var isValid = new RobotValidator().ValidatePosition(position,this);

            if (!isValid)
            {
                throw new InValidActionException(); //Ignored command if position is not valid
            }

            //Everything looks good, save the position
            Robots[robotIndex].SavePosition(position);
        }
       
        public void AddRobot()
        {
            Robots.Add(new BasicRobot());
        }

        public void TakeMultipleAction()
        {
            //TODO: Execute Multiple action from File or in other sources
        }

        private void CheckIfRobotAvailable()
        {
            if (Robots.Count == 0)
            {
                throw new NoRobotException(); // No Robot was added
            }
        }
    }
}
