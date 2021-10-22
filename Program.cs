using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knapsack
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            items.Add(new Item("phone", 2, 98));
            items.Add(new Item("laptop", 30, 300));
            items.Add(new Item("tablet", 5, 65));
            items.Add(new Item("noteBool", 1, 2));
            items.Add(new Item("bottle", 5, 3));

            Rucksack rucksack = new Rucksack(8);

            rucksack.permutation(items);

            List<Item> newItems = rucksack.getRucksack();

            Console.WriteLine("Knapsack problem solution with C#");

            foreach (Item i in newItems)
            {
                Console.WriteLine("item: " + i._name + " weight:" + i._weight + " price: " + i._price);
            }

            

            Console.ReadKey();
        }

    }
}
