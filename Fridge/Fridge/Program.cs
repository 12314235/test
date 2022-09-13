﻿using System;

namespace Programm
{
    struct fridge
    {
        int kg_meat;
        int liters_milk;
        int parts_cheese;
        int cans_beer;

        public fridge(int liters_milk, int kg_meat, int parts_cheese, int cans_beer)
        {
            this.kg_meat = kg_meat;
            this.liters_milk = liters_milk;
            this.parts_cheese = parts_cheese;
            this.cans_beer = cans_beer;
        }

        public void put_smthn_in_fridge(int liters_milk, int kg_meat, int parts_cheese, int cans_beer)
        {
            this.kg_meat += kg_meat;
            this.liters_milk += liters_milk;
            this.parts_cheese += parts_cheese;
            this.cans_beer += cans_beer;
        }

        public void take_smthn_from_fridge(int liters_milk, int kg_meat, int parts_cheese, int cans_beer)
        {
            this.kg_meat -= kg_meat;
            this.liters_milk -= liters_milk;
            this.parts_cheese -= parts_cheese;
            this.cans_beer -= cans_beer;
        }

        public void show_fridge()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Fridge 1:");
            Console.WriteLine("{0} liters of milk", this.liters_milk);
            Console.WriteLine("{0} kg of meat", this.kg_meat);
            Console.WriteLine("{0} parts of cheese", this.parts_cheese);
            Console.WriteLine("{0} cans of beer", this.cans_beer);
            Console.WriteLine("------------------------");
        }
    }
    class Programm
    {
        static void Main()
        {
            Console.WriteLine("Compile 1st fridge(milk, meat, cheese, beer): ");
            string[] input = Console.ReadLine().Split();
            fridge fridge1 = new fridge(Convert.ToInt32(input[0]),
                Convert.ToInt32(input[1]), Convert.ToInt32(input[2]), Convert.ToInt32(input[3]));

            Console.WriteLine("Compile 2nd fridge(milk, meat, cheese, beer): ");
            input = Console.ReadLine().Split();
            fridge fridge2 = new fridge(Convert.ToInt32(input[0]),
                Convert.ToInt32(input[1]), Convert.ToInt32(input[2]), Convert.ToInt32(input[3]));

            while (true)
            {
                Console.WriteLine("Choose fridge:");
                string choose = Console.ReadLine();

                Console.Write("Input command(/help for commands): ");
                string command = Console.ReadLine();

                if (command == "/help")
                {
                    Console.WriteLine("Add - add food\nTake - take food\nShow - show fridge\n");
                    continue;
                }
                else if (command == "Add")
                {
                    Console.Write("Input name and amount: ");
                    input = Console.ReadLine().Split();
                    int amount = Convert.ToInt32(input[1]);
                    if (input[0] == "Milk") { if (choose == "1") fridge1.put_smthn_in_fridge(amount, 0, 0, 0); else fridge2.put_smthn_in_fridge(amount, 0, 0, 0); }
                    if (input[0] == "Meat") { if (choose == "1") fridge1.put_smthn_in_fridge(0, amount, 0, 0); else fridge2.put_smthn_in_fridge(0, amount, 0, 0); }
                    if (input[0] == "Cheese") { if (choose == "1") fridge1.put_smthn_in_fridge(0, 0, amount, 0); else fridge2.put_smthn_in_fridge(0, 0, amount, 0); }
                    if (input[0] == "Beer") { if (choose == "1") fridge1.put_smthn_in_fridge(0, 0, 0, amount); else fridge2.put_smthn_in_fridge(0, 0, 0, amount); }
                }
                else if (command == "Take")
                {
                    Console.Write("Input name and amount: ");
                    input = Console.ReadLine().Split();
                    int amount = Convert.ToInt32(input[1]);
                    if (input[0] == "Milk") { if (choose == "1") fridge1.take_smthn_from_fridge(amount, 0, 0, 0); else fridge2.take_smthn_from_fridge(amount, 0, 0, 0); }
                    if (input[0] == "Meat") { if (choose == "1") fridge1.take_smthn_from_fridge(0, amount, 0, 0); else fridge2.take_smthn_from_fridge(0, amount, 0, 0); }
                    if (input[0] == "Cheese") { if (choose == "1") fridge1.take_smthn_from_fridge(0, 0, amount, 0); else fridge2.take_smthn_from_fridge(0, 0, amount, 0); }
                    if (input[0] == "Beer") { if (choose == "1") fridge1.take_smthn_from_fridge(0, 0, 0, amount); else fridge2.take_smthn_from_fridge(0, 0, 0, amount); }
                }
                else if (command == "Show")
                {
                    if (choose == "1") fridge1.show_fridge();
                    else fridge2.show_fridge();
                }
                Console.WriteLine();
            }
        }
    }
}