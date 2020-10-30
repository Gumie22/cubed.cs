//This is a program for calculating the cubed number given below
using System;

namespace program_1.cs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(cube(5));

            Console.ReadLine();
        }
        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}