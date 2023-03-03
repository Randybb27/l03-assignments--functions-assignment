// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
          myConsoleFunction();
        }
        static string readUserInput(string message) {
            Console.WriteLine(message);
            return Console.ReadLine().ToString();
        }
         static void myConsoleFunction()
        {
            int age;
            string name = readUserInput("What is your name?");
            try {
            string input = readUserInput("How old are you");
            age = Convert.ToInt32(input);
            Console.WriteLine("Hello " + name + " I cant believe you are " + age + " years old");
            Console.ReadLine();
            }
            catch (Exception) {
            Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}

  


