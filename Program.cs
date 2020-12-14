using System;

namespace nameloop
{
    class Program
    {
        static void Main(string[] args)
        {

            string horizontal = "h";
            string vertical = "v";
            Console.Write("Name to write: ");
            string name;
            name = Console.ReadLine();
            Console.Write("Write {0} vertically or horizontally (v/h)", name);
            string writeaxis;
            writeaxis = Console.ReadLine();


            for(int i = 1; i < 11; i++)
            {
                if(vertical == writeaxis.ToLower())
                {
                    string verticalname = " " + i + " " + name;
                    foreach(char c in verticalname)
                    {
                        Console.WriteLine(c);
                    }
                }
                    
                else if(horizontal == writeaxis.ToLower())
                {
                    Console.WriteLine($"{i} \t {name}");
                }
                else
                {
                    Console.WriteLine("fatal error");
                }
                
            }
        }
    }
}
