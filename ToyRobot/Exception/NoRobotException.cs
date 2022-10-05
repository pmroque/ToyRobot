using System;

namespace ToyRobot.Exceptions
{
   public class NoRobotException : Exception
    {

        public NoRobotException()
               : base(String.Format("There is no robot in the Arena."))
        {

        }
    }

}