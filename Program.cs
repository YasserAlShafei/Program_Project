using System;


namespace democonsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Write("Enter radius : ");
            int radius = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter length : ");
            int length = Convert.ToInt32(Console.ReadLine());

            double area = radius * radius * 3.14;
            double volume = area * length;

            Console.WriteLine("=> Value Area is = " +  radius + " * " + radius + " * " + 3.14 + " = " + area);
            Console.WriteLine("=> Value volume is = " +  area + " * " + length + " = " + volume);
        }
    }
}
