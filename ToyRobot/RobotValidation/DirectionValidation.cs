using System;
using System.Linq;
using ToyRobot.Robot;

namespace ToyRobot.RobotValidation
{
    public class DirectionValidation : Validation
    {
        public DirectionValidation(Arena arena)
        {
            this.Arena = arena;
        }
        public override bool Validate(Position position)
        {
            if (position.Direction == null || !Constant.VALID_DIRECTION.Contains(position.Direction))
            {
                return false;
            }
            return true;
        }
    }
}
