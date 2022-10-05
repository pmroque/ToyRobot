
using System;
using ToyRobot.Exceptions;
using ToyRobot.Extension;


namespace ToyRobot.RobotAction
{
    public class ActionParser
    {        

        public Action Parse(string action)
        {
            var str = action.Split(",");
            if (str.Length > 1)
            {
                return ParseParamAction(str);
            }
            return ParseGeneralAction(action);
        }

        private Action ParseGeneralAction(string actionName)
        {
            try
            {
                Type type = Type.GetType($"{Constant.NAMESPACE_ACTION}.{actionName.ToTitleCase()}Action");
                Action instanceAction = Activator.CreateInstance(type) as Action;

                return instanceAction;
            }
            catch (Exception)
            {
                throw new InValidActionException();
            }
        }

        private Action ParseParamAction(string[] str)
        {
            try
            {
                var firstParam = str[0].Split(" ");
                object[] paramsObject = new object[str.Length];
                paramsObject[0] = firstParam[1];
                for (int i = 1; i < str.Length; i++)
                {
                    paramsObject[i] = str[i].Trim();
                }

                Type type = Type.GetType($"{Constant.NAMESPACE_ACTION}.{firstParam[0].ToTitleCase()}Action");
                Action instanceAction = Activator.CreateInstance(type, paramsObject) as Action;

                return instanceAction;
            }
            catch (Exception)
            {
                throw new InValidActionException();
            }
        }
    }
}
