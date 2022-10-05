using System;
using System.Collections.Generic;
using System.Text;
using ToyRobot.Robot;

namespace ToyRobot
{
    public abstract class Validation
    {
        public Arena Arena { get; set; }
        public abstract bool Validate(Position position);
      
    }
}
