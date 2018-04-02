using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Math math = new Math();

                Console.WriteLine("What math function would you like to perform \naddition: 'add' \nsubtraction: 'sub'\nmultiplication: 'mult' \nDivision: 'div': ");
                String function = Console.ReadLine();

                Console.WriteLine("What is your first input: ");
                double input1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What is your second input: ");
                double input2 = Convert.ToDouble(Console.ReadLine());

                switch (function)
                {
                    case "add":
                        math.Add(input1, input2);
                        break;

                    case "sub":
                        math.Subtract(input1, input2);
                        break;

                    case "mult":
                        math.Multiply(input1, input2);
                        break;

                    case "div":
                        math.Divide(input1, input2);
                        break;
                }
            }
            catch
            {
                
            }
        }

        public class Math
        {
            public double Add(double a, double b)
            {
                return a + b;
            }

            public double Subtract(double a, double b)
            {
                return a - b;
            }

            public double Multiply(double a, double b)
            {
                return a * b;
            }

            public double Divide(double a, double b)
            {
                return a / b;
            }
        }
    }
}
