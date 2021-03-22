using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    class UserInput
    {
        Salad salad = new Salad();

        //Main menu that provides user with the possibility to create a salad, see its contents, sort and search the vegetables  
        public void MainMenu()
        {
            int choice = -1;
            Console.WriteLine("Create your own salad!\n");
            while (choice != 0)
            {
                Console.WriteLine("Select one of the options below: ");
                Console.WriteLine("1. Add an item");
                Console.WriteLine("2. Display the salad content");
                Console.WriteLine("3. Find a vegetable by kkal");
                Console.WriteLine("4. Sort vegetables by kkal");
                Console.WriteLine("0. Exit\n");
                choice = Convert.ToInt32(Console.ReadLine());
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("No such option! Please, try again or press 0 to exit!\n");
                    Console.ReadLine();
                    choice = -1;
                }
                switch (choice)
                {
                    case 1:
                        Salad.CreateSalad();
                        break;
                    case 2:
                        salad.DisplaySaladContent();
                        break;
                    case 3:
                        salad.FindByKkal();
                        break;
                    case 4:
                        salad.SortByKkal();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}

