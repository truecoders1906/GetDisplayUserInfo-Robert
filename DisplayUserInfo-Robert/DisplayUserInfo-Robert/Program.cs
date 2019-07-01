using System;

namespace DisplayUserInfo_Robert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("What is your first name?");

            string firstName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(firstName + ", what is your last name?");

            string lastName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(firstName + " " + lastName + "? What a great name!");
            Console.WriteLine();
            Console.WriteLine("What is your favorite number?");
            string number1 = Console.ReadLine();
            Console.WriteLine();
            if(number1 == "18")
            {
                Console.WriteLine(number1 + "!? " + "Mine is 18! "
                    + firstName + ", you have a good taste in numbers!");
            }
            else
            {
                Console.WriteLine(number1 + "!? " + "18 is wayyy better!");
            }
        }
    }
}
