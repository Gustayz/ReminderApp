using System;

namespace ReminderApp
    {
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, please enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}, how can i help you today?");
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Choose an option below");
            Console.WriteLine("----------------------*");
            Console.WriteLine("*1. Add a reminder    *");
            Console.WriteLine("*2. Remove a reminder *");
            Console.WriteLine("*3. Edit a reminder   *");
            Console.WriteLine("*4. Exit program      *");
            Console.WriteLine("----------------------*");
        }
    }

    }