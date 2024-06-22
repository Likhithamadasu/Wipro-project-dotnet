using System;
using System.Collections.Generic;

namespace FractionalKnapsack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of items with Profit and Weight
            List<Item> items = new List<Item>
            {
                new Item(50, 3),
                new Item(40, 4),
                new Item(90, 6),
                new Item(10, 4),
                new Item(5, 1),
                new Item(11, 2),
                new Item(70, 5),
                new Item(15, 2)
            };

            // Weight capacity of the knapsack
            int capacity = 20;

            // Create an instance of FractionalKnapsack and find the maximum profit
            FractionalKnapsack fractionalKnapsack = new FractionalKnapsack();
            double maxProfit = fractionalKnapsack.GetMaxProfit(items, capacity);

            // Print the maximum profit
            Console.WriteLine($"Maximum Profit: {maxProfit}");
        }
    }

    // This class helps to sort items by their value-to-weight ratio in descending order
    public class SortItemByRatio : IComparer<Item>
    {
        public int Compare(Item x, Item y)
        {
            double ratioX = (double)x.Profit / x.Weight;
            double ratioY = (double)y.Profit / y.Weight;
            return ratioY.CompareTo(ratioX);
        }
    }

    // This class represents an Item with Profit and Weight
    public class Item
    {
        public int Profit { get; set; }
        public int Weight { get; set; }

        public Item(int profit, int weight)
        {
            Profit = profit;
            Weight = weight;
        }
    }

    // This class contains the logic for the fractional knapsack problem
    public class FractionalKnapsack
    {
        public double GetMaxProfit(List<Item> items, int capacity)
        {
            // Sort the items by value-to-weight ratio in descending order
            items.Sort(new SortItemByRatio());

            double totalProfit = 0.0;
            int remainingCapacity = capacity;

            // Iterate through the sorted items
            foreach (Item item in items)
            {
                // If the entire item can be taken, take it
                if (item.Weight <= remainingCapacity)
                {
                    totalProfit += item.Profit;
                    remainingCapacity -= item.Weight;
                }
                else
                {
                    // If only a fraction of the item can be taken, take the fraction
                    double fraction = (double)remainingCapacity / item.Weight;
                    totalProfit += item.Profit * fraction;
                    break; // Knapsack is full
                }
            }

            return totalProfit;
        }
    }
}
