using System;
using System.Reflection;

namespace CustomAttribute
{
   
    [AttributeUsage(AttributeTargets.Class |
    AttributeTargets.Constructor |
    AttributeTargets.Field |
    AttributeTargets.Method |
    AttributeTargets.Property,
    AllowMultiple = true)]

    public class LogTime : System.Attribute                                                         //Class for creating custom attribute
    {
        public String time;

        
          
        public LogTime()                                                                           //Constructor of custom attribute(LogTime) for creating Log time
        {
            this.time = (DateTime.UtcNow).ToString();

        }

    }
    
}
    
