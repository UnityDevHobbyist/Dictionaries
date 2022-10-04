using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> fruits = new Dictionary<int, string>();
            fruits.Add(1, "Apple");
            fruits.Add(2, "Banana");
            fruits.Add(4, "Orange");

            foreach (KeyValuePair<int, string> kvp in fruits)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            var cities = new Dictionary<string, string>()
            {
                {"France", "Paris"},
                {"Netherlands", "Amsterdam"}
            };

            foreach (var kvp in cities)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            var colours = new Dictionary<int, string>()
            {
                {1, "Red"},
                {2, "Yellow"}
            };

            foreach (var kvp in colours)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            var bosses = new Dictionary<int, string>()
            {
                {1, "Goblin"},
                {2, "Monster"},
                {3, "Knight"}
            };

            foreach (var kvp in bosses)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            var books = new Dictionary<int, string>()
            {
                {1, "The Hunger Games"}
            };

            foreach (var kvp in books)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            IDictionary<int, string> vegetables = new Dictionary<int, string>();
            vegetables.Add(1, "Cucumber");
            vegetables.Add(2, "Cauliflower");

            foreach (KeyValuePair<int, string> kvp in vegetables)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            IDictionary<int, string> food = new Dictionary<int, string>();
            food.Add(1, "Lasagna");
            food.Add(2, "Maccaroni");
            food.Add(4, "Hamburger");

            foreach (KeyValuePair<int, string> kvp in food)
                Console.WriteLine("Key: {0}, Value {1}", kvp.Key, kvp.Value);

            Console.ReadKey(false);
        }
    }
}