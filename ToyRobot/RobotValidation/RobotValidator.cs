using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ToyRobot.Robot;

namespace ToyRobot
{
    public class RobotValidator
    {
        
        public bool ValidatePosition(Position position, Arena arena)
        {
            IEnumerable<string> names = GetAllValidationClassName(Constant.NAMESPACE_VALIDATION);

            foreach (var name in names)
            {
                Type type = Type.GetType($"{Constant.NAMESPACE_VALIDATION}.{name}");

                Validation instance = Activator.CreateInstance(type, arena) as Validation;

                if (!instance.Validate(position))
                {
                    return false;
                }
            }
            return true;
        }

        private static IEnumerable<string> GetAllValidationClassName(string nameSpace)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            var p = asm.GetTypes()
                .Where(type => type.Namespace == nameSpace)
                .Select(type => type.Name);
            return p;
        }
    }
}
