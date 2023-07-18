using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool counter = true;
            while (counter)
            {
                decimal num1,num2;
                char option;
                Console.WriteLine("enter the number to do the operation on it :");
                Console.WriteLine("enter the first  number : ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the second: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the operation: ");
                option =  Convert.ToChar(Console.ReadLine());
                switch (option)
                {
                    case '+':
                        Console.WriteLine("the result is "+ (num1+num2));                      
                        break;
                    case '-':
                        Console.WriteLine("the result is " + (num1 - num2));                        
                        break;
                    case '*':
                        Console.WriteLine("the result is " + (num1 * num2));
                        break;
                    case '/':
                        Console.WriteLine("the result is " + Convert.ToDecimal((num1 / num2)));
                        break;
                    default:
                        Console.WriteLine("that's not rigt operation try again");
                        counter = false; Console.ReadLine();
                        break;      
                        
                }
            }
            
        }
    }
}
