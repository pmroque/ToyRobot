using System;
using System.Collections.Generic;
using System.Text;
using ToyRobot.Robot;

namespace ToyRobot.RobotValidation
{
    public class RobotInsideTheTableValidation : Validation
    {       

        public RobotInsideTheTableValidation(Arena arena)
        {
            this.Arena = arena;
        }

        public override bool Validate(Position position)
        {
            if (position.Y < 0 || position.Y >= this.Arena.Y)
            {
                return false;
            }

            if (position.X < 0 || position.X >= this.Arena.X)
            {
                return false;
            }

            return true;
        }
    }
}
