using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
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
                Console.WriteLine("5. Save salad to TEXT file");
                Console.WriteLine("6. Load salad from TEXT file");
                Console.WriteLine("7. Save salad to XML file");
                Console.WriteLine("8. Load salad from XML file");
                Console.WriteLine("9. Save salad to BINARY file");
                Console.WriteLine("10. Load salad from BINARY file");
                Console.WriteLine("0. Exit\n");
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
                        Salad.AddItem();
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
                    case 5:
                        salad.WriteTXT();
                        break;
                    case 6:
                        salad.ReadTXT();
                        break;
                    case 7:
                        salad.SerializeAndSaveXML();
                        break;
                    case 8:
                        salad.ReadAndDeserializeXML();
                        break;
                    case 9:
                        salad.WriteBinary();
                        break;
                    case 10:
                        salad.ReadBinary();
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

