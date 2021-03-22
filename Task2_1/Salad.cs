using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    public class Salad
    {
        public static List<Vegetable> vegetables = new List<Vegetable>();
        public static double VegetableWeight { get; set; }

        // Adds vegetables according to the user's input
        public static void CreateSalad()
        {
            int menu_choice = -1;
            string noCategory = "No such category!\n";
            string noVegetable = "No vegetables in the chosen category!\n";
            while (menu_choice != 0)
            {
                Console.WriteLine("Select a vegetable category, please:");
                Console.WriteLine("1. Vegetative Vegetables");
                Console.WriteLine("2. Fruit Vegetables");
                Console.WriteLine("0. Show the main menu\n");
                try
                {
                    menu_choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine(noCategory);
                    Console.ReadLine();
                    menu_choice = -1;
                }

                switch (menu_choice)
                {
                    case 1:
                        Console.WriteLine("Select a vegetable: 1. Onion, 2. Radish\n");
                        try
                        {
                            int option = Convert.ToInt32(Console.ReadLine());
                            switch (option)
                            {
                                case 1:
                                    {
                                        Onion vegetable = new Onion();
                                        AddVegetable(vegetable);
                                        VegetableWeight += vegetable.VegetableWeight;
                                        break;
                                    }
                                case 2:
                                    {
                                        Radish vegetable = new Radish();
                                        AddVegetable(vegetable);
                                        VegetableWeight += vegetable.VegetableWeight;
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine(noVegetable);
                                        Console.ReadLine();
                                        menu_choice = -1;
                                        break;
                                    }
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine(noCategory);
                            Console.ReadLine();
                            menu_choice = -1;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Select a vegetable: 1. Cucumber, 2. Tomato\n");
                        try
                        {
                            int option2 = Convert.ToInt32(Console.ReadLine());
                            switch (option2)
                            {
                                case 1:
                                    {
                                        Cucumber vegetable = new Cucumber();
                                        AddVegetable(vegetable);
                                        VegetableWeight += vegetable.VegetableWeight;
                                        break;
                                    }
                                case 2:
                                    {
                                        Tomato vegetable = new Tomato();
                                        AddVegetable(vegetable);
                                        VegetableWeight += vegetable.VegetableWeight;
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine(noVegetable);
                                        Console.ReadLine();
                                        menu_choice = -1;
                                        break;
                                    }
                            }

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine(noCategory);
                            Console.ReadLine();
                            menu_choice = -1;
                        }
                        break;
                    case 0:
                        menu_choice = 0;
                        break;

                    default:
                        Console.WriteLine(noCategory);
                        break;
                }
            }
        }

        //Adds a vegetable to the salad
        public static void AddVegetable(Vegetable vegetable)
        {
            vegetables.Add(vegetable);
            Console.WriteLine("The vegetable was added to the salad!\n");
        }

        //Removes a vegetable from the salad
        public void RemoveVegetables(string name)
        {
            List<Vegetable> itemsToRemove = new List<Vegetable>();
            foreach (Vegetable vegetable in vegetables)
            {
                if (vegetable.Name == name)
                {
                    itemsToRemove.Add(vegetable);
                }
            }
            if (itemsToRemove.Count != 0)
            {
                foreach (Vegetable vegetable in itemsToRemove)
                {
                    vegetables.Remove(vegetable);
                    Console.WriteLine("The vegetables were removed!\n");
                }
            }
            else
            {
                Console.WriteLine("No items to remove!\n");
            }
        }

        //Shows what vegetables are contained in the salad, removes vegetables from salad
        public void DisplaySaladContent()
        {
            if (vegetables == null)
            {
                Console.WriteLine("There are no vegetables in the salad!\n");
            }
            else
            {
                UserInput input = new UserInput();
                Console.WriteLine("Your salad contains the following items: ");
                foreach (Vegetable vegetable in vegetables)
                {
                    Console.WriteLine(vegetable.Name + " " + Convert.ToString(vegetable.VegetableWeight) + "g.");
                }
                Console.WriteLine("Total weight: " + VegetableWeight + "g.\n");
            }

            Console.WriteLine("Do you want to remove any vegetables? (yes/no): ");
            string removeOption = Console.ReadLine();
            switch (removeOption)
            {
                case "yes":
                    Console.WriteLine("Enter the vegetable name please: ");
                    string vegetablesToRemove = Console.ReadLine();
                    RemoveVegetables(vegetablesToRemove);
                    break;

                case "no":
                    break;
                default:
                    Console.WriteLine("No such option!\n");
                    break;
            }
        }

        //Calculates the total weight of the salad
        public double SaladWeight()
        {
            double VegetableWeight = 0.0;
            foreach (Vegetable vegetable in vegetables)
            {
                VegetableWeight += vegetable.VegetableWeight;
            }
            return VegetableWeight;
        }

        //Sorts the vegetables in the present by Kkal
        public void SortByKkal()
        {
            KkalSorter kkal = new KkalSorter();
            vegetables.Sort(kkal);
            foreach (Vegetable vegetable in vegetables)
            {
                Console.WriteLine(vegetable.Name + " " + vegetable.Kkal);
            }
        }

//Allows to find a vegetable/vegetables by specifying the kkal range
public void FindByKkal()
{
    double kkal;
    Console.WriteLine("Enter min kkal: ");
    double minKkal = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter max kkal: ");
    double maxKkal = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("The following vegetables fit into the specified kkal range (" + minKkal + " - " + maxKkal + "): \n");
    foreach (Vegetable vegetable in vegetables)
    {
        kkal = vegetable.Kkal;
        if (kkal >= minKkal && kkal <= maxKkal)
        {
            Console.WriteLine(vegetable.Name + ", " + vegetable.Kkal + ". ");
        }
        else
        {
            Console.WriteLine("No vegetables in this range!\n");
        }
    }
}
    }
}
