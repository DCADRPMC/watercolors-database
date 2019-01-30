using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> stuff = new List<string>(); 
                while (true)
            {
                Console.WriteLine("possible commands: add, remove, list");
                Console.WriteLine("what is your command?");
                    string command = Console.ReadLine();
                if (command == "add")
                {
                    //add
                    Console.WriteLine("what do you want added?");
                    
                    string name = Console.ReadLine();
                    stuff.Add(name);
                    Console.WriteLine($"{name} was added to the list ");
                }
                // 
                if (command == "remove")
                {
                    //if (contains.stuff == true)
                    Console.WriteLine("what do want to remove?");

                    string name = Console.ReadLine();
                    stuff.Remove(name);
                    Console.WriteLine($"{name} was removed from the list ");
                }
                else
                    Console.WriteLine($" could not be found");




                if (command == "list")
                {
                    stuff.ForEach(Console.WriteLine);





                }








            }
            

        }
    }
}
