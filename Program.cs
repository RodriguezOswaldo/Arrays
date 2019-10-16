using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {3, 5, 7, 9, 2, 15, 12};
            //Length
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Length: " + numbers.Length);
            
            //Index
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("index of 9: "+ index);

            //Clear
            Array.Clear(numbers, 0, 2);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //copy
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of copy()");
            foreach (var n in another)
                Console.WriteLine(n);
          

            //Sort
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");
            foreach (var sort in numbers)
            {
                Console.WriteLine(sort);
            }

            //Reverse
            Array.Reverse(numbers);

            Console.WriteLine("Effect of Reverse(): ");
            foreach (var reverse in numbers)
                Console.WriteLine(reverse);
            {
                
            }

        }
    }
}
