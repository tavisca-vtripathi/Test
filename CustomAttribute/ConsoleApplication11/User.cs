using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttribute                                                                        
{
   
    class User                                                                    //Create class for user who is accessing file
    {
        string name;
        public User(String str)                                                     // constructor for catching user name at runtime
        {
            this.name = str;
        
        }
        [LogTime()]                                                                //Attaching custom attribute here
        public string getName()                                                    //Function for returning name of user
        {
            return name;
        
        }

    }
}
