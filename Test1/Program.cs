﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("hELLO {0}",new Program().Hello(Convert.ToString(Console.ReadLine())));
<<<<<<< HEAD
=======
            int a =Convert.ToInt16(Console.ReadLine());
            string b= Convert.ToString(Console.ReadLine());
            User A=new User(b,a);
           Console.Write(A.GetInfo(A));
>>>>>>> refs/remotes/origin/features
        }

        public string  Hello(string name)
        {
            return "Hello," + name + "!";
<<<<<<< HEAD
=======
        }

        public int Plus(int a, int b)
        {
            return a + b;
>>>>>>> refs/remotes/origin/features
        }
    }
}
