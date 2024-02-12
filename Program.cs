using System;

namespace Calculator
{
    class Calculator
    {
        public string inputNum()
        {
            double check = 0;
            string num = "";
            bool flag = false;

            do
            {
                try
                {
                    check = Convert.ToDouble(num = Console.ReadLine());
                    flag = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.Write("Input Operand Again: ");
                }
            }
            while (!flag);

            return num;
        } 

        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            string num1 = null;
            string num2 = null;
            double temp;
            int choice = 0;

            Console.WriteLine("Calculator");
            do
            {
                if(num1 == null)
                {
                    Console.Write("Input Operand 1: ");
                    num1 = c.inputNum();
                }

                Console.Write("Input Operand 2: ");
                num2 = c.inputNum();

                Console.WriteLine("1 - Add\n" +
                                  "2 - Subtract\n" +
                                  "3 - Multiply\n" +
                                  "4 - Divide");

                Console.Write("Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: //Add
                        temp = Convert.ToDouble(num1) + Convert.ToDouble(num2);
                        Console.WriteLine("{0} + {1} = {2}",
                                           num1, num2, num1 = Convert.ToString(temp.ToString("0.##")));
                        break;
                    case 2: //Subtract
                        temp = Convert.ToDouble(num1) - Convert.ToDouble(num2);
                        Console.WriteLine("{0} - {1} = {2}",
                                           num1, num2, num1 = Convert.ToString(temp.ToString("0.##")));
                        break;
                    case 3: //Multiply
                        temp = Convert.ToDouble(num1) * Convert.ToDouble(num2);
                        Console.WriteLine("{0} * {1} = {2}",
                                           num1, num2, num1 = Convert.ToString(temp.ToString("0.##")));
                        break;
                    case 4: //Divide
                        if(Convert.ToDouble(num2) != 0)
                        {
                            temp = Convert.ToDouble(num1) * Convert.ToDouble(num2);
                            Console.WriteLine("{0} / {1} = {2}",
                                                num1, num2, num1 = Convert.ToString(temp.ToString("0.##")));
                        } else
                        {
                            Console.WriteLine("Result is undefined. Resetting...");
                            num1 = null;
                            num2 = null;
                        }

                        break;
                    default:
                        Console.WriteLine("Operation does not exist. Resetting...");
                        num1 = null;
                        num2 = null;
                        break;
                }

            } while (true);
        }

    }
}