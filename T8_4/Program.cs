using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T8_4
{
    internal class Program
    {
        //Task 1
        //Write a program, as a result of which the value of a is exchanged with the value of b, and the value of b - with the value of c.
        //Define a method that exchanges the values of two variables.

        /*static void Swap(ref int a, ref int b,ref int c)
        {
            int p = a;
            a = b;
            b = c;
            c = p;
        }*/


        //Task 2
        //Enter three integers and output them in ascending order of values.

        /*static void Rise(ref int x, ref int y, ref int z)
        {
            if (x > y)
            {
                int p = x;
                x = y;
                y = p;
            }
            else if (y > z)
            {
                int p = y;
                y = z;
                z = p;
            }
            else if (x > y)
            {
                int p = x;
                x = y;
                y = p;
            }
        }*/


        //Task 3
        //Create a method that calculates the area of a circle and the length of a circle.
        //The calling program code should pass the radius value as an argument to the method and print the value of radius, circle area and circle length.

        /*static void Circle(ref double radius)
        {
            double s = Math.PI * radius * radius;
            double l = 2 * Math.PI * radius;
            Write($"\nRadius: {radius}\tArea: {s:f2}\tLength: {l:f2}");
        }*/


        //Task 4
        //Two sentences are given. Find the total number of letters "n" in them. (Define function to calculate the number of "n "s in a sentence.)

        /*static int Count(ref string sen_1)
        {
            int count = 0;
            foreach (char n in sen_1)
            {
                if (n == 'н' || n == 'Н')
                {
                    count++;
                }
            }
            return count;
        }*/

        static void Main(string[] args)
        {
            try
            {
                //Task 1
                //Write a program, as a result of which the value of a is exchanged with the value of b, and the value of b - with the value of c.
                //Define a method that exchanges the values of two variables.

                /*Write("Enter a: ");
                int a = Convert.ToInt32(ReadLine());
                Write("Enter b: ");
                int b = Convert.ToInt32(ReadLine());
                Write("Enter c: ");
                int c = Convert.ToInt32(ReadLine());

                Swap(ref a, ref b, ref c);
                WriteLine($"{a}\t{b}\t{c}");*/


                //Task 2
                //Enter three integers and output them in ascending order of values.

                /*Write("Enter x: ");
                int x = Convert.ToInt32(ReadLine());
                Write("Enter y: ");
                int y = Convert.ToInt32(ReadLine());
                Write("Enter z: ");
                int z = Convert.ToInt32(ReadLine());

                Rise(ref x, ref y, ref z);
                WriteLine($"{x}\t{y}\t{z}");*/


                //Task 3
                //Create a method that calculates the area of a circle and the length of a circle.
                //The calling program code should pass the radius value as an argument to the method and print the value of radius, circle area and circle length.

                /*Write("Enter the radius of the circle: ");
                double radius = Convert.ToDouble(ReadLine());
                Circle(ref radius);*/


                //Task 4
                //Two sentences are given. Find the total number of letters "n" in them. (Define function to calculate the number of "n "s in a sentence.)

                /*Write("Enter the first sentence: ");
                string sen_1 = ReadLine();
                Write("Enter the second sentence: ");
                string sen_2 = ReadLine();

                Write($"Quantity of н: {Count(ref sen_1) + Count(ref sen_2)}");*/

            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
