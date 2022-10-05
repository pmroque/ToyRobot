using System;
using System.Threading.Tasks;
using ToyRobot.Robot;
namespace ToyRobot.RobotAction
{
    public class ReportAction : Action
    {
        
        public ReportAction()
        {
            IsMovableAction = false;
        }
        public override async Task DoActionAsync(Position poistion)
        {
            base.ActionMessage = poistion.ToString();
        }
    }
}
