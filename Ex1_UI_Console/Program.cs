using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex1_UI_Console
{
    class Program
    {
        static Ex1_BL.MyBl bl = new Ex1_BL.MyBl();

        static void Main(string[] args)
        {            
            Console.WriteLine(bl.getResult());
            Console.ReadLine();
        }
    }
}
