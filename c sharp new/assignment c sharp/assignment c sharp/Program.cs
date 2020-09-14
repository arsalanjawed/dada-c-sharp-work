using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace assignment_c_sharp
{
    abstract class Animal
    {
        
        public virtual void eating_cost(string name,int price, int eat_per_day) 
        {
        }
    }
    public interface print
    {
        void print_animals();
    }
    public interface saved 
    {
        void save_animal();
    }
    class Emu:Animal,print,saved
    {
        int Age ;
        double Weight;
        double Height;
        string Name;
        int day;
        int result;

        
        public void save_animal()
        {
            String filepath = @"C:\csharptext\text1.txt";
            List<string> lines = new List<string>();
            lines.Add("Emu");
            File.WriteAllLines(filepath, lines);
        }
        public void print_animals()
        {
            String filepath = @"C:\csharptext\text1.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filepath).ToList();
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        
         public override void eating_cost(string name, int price, int eat_per_day)
         {
             Name = name;
             day = price * eat_per_day;
             result = day * 30;

             Console.WriteLine("The cost of {0} food is {1}$ and how many time they eat in a day {2}. Total cost of the food consume per day {3}$ and {4}$ per month.", name, price, eat_per_day, day, result);
         }
         public Emu()
         {
             Console.WriteLine("This is emu class default constructor");
         }

         public Emu(string name)
         {
             Name = name;
             Console.WriteLine("This is emu class animal name {0}" ,name);
            
         }
        public Emu(int age)
        {
            Age = age;
            Console.WriteLine("This is emu class animal age {0}", age);
        }
        public Emu(double weight, double height)
        {
            Weight = weight;
            Height = height;
            Console.WriteLine("This is emu class animal weight {0}kg and height {1}",weight,height );
        }
        public Emu(string name, int age,double weight, double height)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;

            Console.WriteLine("The detail of the animal is name {0} , age {1}, weight {2} kg , height {3}", Name,Age,Weight,Height);

        }
    }
    
    class Kangaroo : Animal, print, saved
    {
        string Name = "Kangaroo";
        int day;
        int result;
        int Age = 1 ;
        double Weight = 2;
        double Height = 3.3;
        public void save_animal()
        {
          
           String filepath = @"C:\csharptext\csharptext.txt";
           List<string> lines = new List<string>();
            lines.Add("Kangaroo");
            File.WriteAllLines(filepath, lines);
        }
        public void print_animals()
        {
            String filepath = @"C:\csharptext\csharptext.txt";
            List <string> lines = new List<string>();
            lines = File.ReadAllLines(filepath).ToList();
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
       
        }
        public override void eating_cost(string name, int price, int eat_per_day)
        {
            Name = name;
            day = price * eat_per_day;
            result = day * 30;

            Console.WriteLine("The cost of {0} food is {1}$ and how many time they eat in a day {2}. Total cost of the food consume per day {3}$ and {4}$ per month.", name, price, eat_per_day, day, result);
        }
        public Kangaroo()
         {
             Console.WriteLine("This is kangaroo class default constructor");
         }
        public Kangaroo(string name)
        {
            Name = name;
            Console.WriteLine("This is emu class animal name {0} ", name);

        }
        public Kangaroo(int age)
        {
            Age = age;
            Console.WriteLine("This is emu class animal age {0} ", age);
        }
        public Kangaroo(double weight, double height)
        {
            Weight = weight;
            Height = height;
            Console.WriteLine("This is emu class animal weight {0}kg and height {1} ",weight,height );
        }
        public Kangaroo(string name, int age,double weight, double height)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
            Console.WriteLine("The detail of the animal is name {0} , age {1}, weight {2} kg , height {3}", Name, Age, Weight, Height);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
           
            Kangaroo a = new Kangaroo();
            Kangaroo b = new Kangaroo("kangaroo");
            Kangaroo c = new Kangaroo(5);
            Kangaroo d = new Kangaroo(18,6.5);
            Kangaroo q = new Kangaroo("kangaroo",3,30,7.5);
            a.eating_cost("Kangaroo", 12, 2);
            a.save_animal();
            a.print_animals();
            Emu e = new Emu();
            Emu w = new Emu("Emu");
            Emu t = new Emu(8);
            Emu r = new Emu(10, 5.5);
            Emu y = new Emu("Emu", 2, 12, 6.5);
            e.eating_cost("Emu", 20, 2);
            e.save_animal();
            e.print_animals();
            

            Console.ReadLine();
        }
    }
}
