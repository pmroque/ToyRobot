using System;

namespace ToyRobot.Exceptions
{

    public class InValidActionException : Exception
    {    

        public InValidActionException()
            : base(String.Format("Not A valid action"))
        {

        }
    }


}
