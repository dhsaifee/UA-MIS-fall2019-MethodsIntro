using System;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            // Call the method SayHello as pass the argument userName by value to it
            SayHello(userName);
            Console.WriteLine("Hello " + userName);

            // \n is the new line character and moves the cursor on the Console to the next line.
            Console.WriteLine("\n\n");

            // Call the method SayHello2 as pass the argument userName by reference to it
            SayHello2(ref userName);
            Console.WriteLine("Hello " + userName);

            Console.WriteLine("\n\n");

            int number1 = 10;
            int number2 = 20;

            // Call the method SumTwoNumbers and pass the the arguments number1 and number2 to it by value
            // This method returns an integer value which gets stored in the variable sum
            int sum = SumTwoNumbers(number1, number2);

            Console.WriteLine("the sum is: " + sum);

            Console.ReadKey();

        }

        static string SayHello(string userName)
        {
            Console.WriteLine("Hello " + userName);

            userName = "Jeff";

            Console.WriteLine("Hello " + userName);

            return userName;
        }

        static string SayHello2(ref string userName)
        {
            Console.WriteLine("Hello " + userName);

            userName = "Jeff";

            Console.WriteLine("Hello " + userName);

            return userName;
        }


        static int SumTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

    }
}
