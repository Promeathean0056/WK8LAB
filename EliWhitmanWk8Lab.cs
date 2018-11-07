using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eliwhitmanlabw8
{
    class Program
    {
        static void Main(string[] args)
        {
            int control1 = 1;/*This is the control variable*/
            int counter = 0;/*this is the counter*/
            while(control1 < 10)
            {
                Console.WriteLine(control1);
                control1 = control1 + 2;
                
            }
            Console.ReadLine();
            int control2 = 35;/*this the control variable for the second loop*/
            while (control2 < 46)
            {
                Console.WriteLine(control2);
                control2++;
            }
            Console.ReadLine();
            int hour = 11;
            if(hour < 12)
            {
                Console.WriteLine("Good Morning.");
            }
            else if(hour > 16)
            {
                Console.WriteLine("Good Evening.");
            }
            else
            {
                Console.WriteLine("Good Afternoon.");
            }
            Console.ReadLine();
            /*the following code is used to correct Question #4*/
            int Numfour = 10;
            while (Numfour < 21)
            {
                Console.WriteLine(Numfour);
                Numfour++;
            }
            Console.ReadLine();
            /*The Following Code is for question number five*/
            int Numfive = 0;
            while (Numfive < 101)
            {
                Console.WriteLine(Numfive);
                Console.WriteLine("********");
                Numfive++;
            }
            Console.ReadLine();


        }
    }
}
