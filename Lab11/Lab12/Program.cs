using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1) Enter numbers manually");
            Console.WriteLine("2) Random generated numbers");
            if (int.TryParse(Console.ReadLine().ToString(), out int option))
            {
                if (option == (int)1)
                    Option1();
                else if (option == (int)2)
                    Option2();
                else
                {
                    Console.WriteLine("The number has to be either 1 or 2");
                    Console.ReadKey();
                }
                
            }
            else
            {
                Console.WriteLine("The value you entered is invalid");
                Console.ReadKey();
            }
            
        }

        private static void Option2()
        {
            Console.WriteLine("Enter the number of numbers N: ");
            if (int.TryParse(Console.ReadLine(), out int N))
            {
                int[] array = new int[N];
                Random random = new Random();
                for (int i = 0; i < N; i++)
                {
                    array[i] = random.Next(1, 1000);
                }
                //Console.WriteLine("The average value is {0}", array.Average());
                //Console.WriteLine("The minimum value is {0}", array.Min());
                //Console.WriteLine("The maximum value is {0}", array.Max());               
                FindAverage(array, out double Average);
                FindMax(array, out int Max);
                FindMin(array, out int Min);
                Console.WriteLine("The average value is {0}", Average);
                Console.WriteLine("The minimum value is {0}", Min);
                Console.WriteLine("The maximum value is {0}", Max);
                Console.ReadKey();
            }
        }

        public static void Option1()
        {
            Console.WriteLine("Enter the number of numbers N: ");
            if(int.TryParse(Console.ReadLine(), out int N))
            {
                int [] array = new int[N];
                for (int i = 0; i < N; i++)
                {
                    array[i] = int.Parse(Console.ReadLine().ToString());
                }
                //Console.WriteLine("The average value is {0}", array.Average());
                //Console.WriteLine("The minimum value is {0}", array.Min());
                //Console.WriteLine("The maximum value is {0}", array.Max());
                FindAverage(array, out double Average);
                FindMax(array, out int Max);
                FindMin(array, out int Min);
                Console.WriteLine("The average value is {0}", Average);
                Console.WriteLine("The minimum value is {0}", Min);
                Console.WriteLine("The maximum value is {0}", Max);
                Console.ReadKey();
            }
        }
        public static void FindMin(int [] array, out int Min)
        {
            Min = array.Min();
        }
        public static void FindMax(int[] array, out int Max)
        {
            Max = array.Max();
        }
        public static void FindAverage(int[] array, out double Average)
        {
            Average = array.Average();
        }
    }
}
/*
 * try
                    { 
                        int c = int.Parse(Console.ReadLine());
                        if (flag == 0)
                        {
                            min = c;
                            max = c;
                            flag = 1;
                        }
                        else
                        {
                            if (c < min)
                                min = c;
                            if (c > max)
                                max = c;
                        }
                        sum += c;
                        counter++;
                    }
                    catch(FormatException e)
                    {
                        Console.WriteLine("The value is not a number");
                    }
 */
