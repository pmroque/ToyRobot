using System;

namespace ToyRobot.Exceptions
{
  
    public class InvalidPositionException : Exception
    {

        public InvalidPositionException()
            : base(String.Format("Invalid position"))
        {

        }
    }
}
