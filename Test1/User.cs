﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class User
    {
         string name;
        private int id;

        public User(string name,int id)
        { 
            this.name =name;
            this.id = id;
        }
            
        
        public string GetInfo(User a)
        {
            return "user with id" + a.id + "is" + a.name;
        }
    }


}
