using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Threading;
namespace CustomAttribute
{
    class Program                                                                     //Main program for controlling code flow
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");                                   
            string getname = Console.ReadLine();                                     //getname stores user name   
            User us = new User(getname);
            Type type = typeof(User);
            foreach (MethodInfo mInfo in type.GetMethods())                              //Reflections used for accessing custom attribute methods and variable
            {
                foreach (Attribute attribute in mInfo.GetCustomAttributes(true))
                {
                    try
                    {
                        LogTime logTime = (LogTime)attribute;
                        if (null != logTime)
                        {
                            string output = "";

                        Console.WriteLine("User Name {0} accessed method :"+mInfo.Name+ " on time {1}", us.getName(), logTime.time);  //displaying name of user accessing method with time on console
                        
                       

                            output="User Name "+us.getName()+" accessed method : "+mInfo.Name+" on time "+logTime.time;                 //Maintaining log in file for the no. of user who accessed method                 
                            string path = @"C:\Users\vtripathi\Documents\Visual Studio 2012\Projects\CustomAttribute\LogFile.txt";  //Path of the file where log is created
                            

                            FileStream fileStream = new FileStream(path,FileMode.Append,FileAccess.Write);                             //Concept of file handling is used 
                            StreamWriter streamWriter = new StreamWriter(fileStream);

                            streamWriter.WriteLine(output);
                            streamWriter.Close();
                            fileStream.Close();

                               
                       }
                    }

                    
                    catch (Exception e) 
                    
                    { 
                    
                    
                    }

                }
            }

        }
        
    }
}
