using System;
namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;

            for (; ; )
            {
                Console.WriteLine("Enter length");

                string input = (Console.ReadLine());

                if (Int32.TryParse(input, out length) && length > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                    continue;
                }

            }

            int[] mass1 = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Enter {i} number");

                string input2 = (Console.ReadLine());

                if (Int32.TryParse(input2, out mass1[i]))
                {

                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                    i--;
                }
            }
            
            int temp;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i ; j < length; j++)
                {
                    if (mass1[i] > mass1[j])
                    {
                        temp = mass1[i];
                        mass1[i] = mass1[j];
                        mass1[j] = temp;
                    }
                }
            }

          
            
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(mass1[i]);
            }
            
        }
    }
}


















//using System;  

//namespace ConsoleApp13
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int length;

//            for (; ; )
//            {
//                Console.WriteLine("Enter length");

//                string input = (Console.ReadLine());

//                if (Int32.TryParse(input, out length) && length > 0)
//                {
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Некорректный ввод");
//                    continue;
//                }

//            }

//            int[] mass1 = new int[length];

//            for (int i = 0; i < length; i++)
//            {
//                Console.WriteLine($"Enter {i} number");

//                string input2 = (Console.ReadLine());

//                if (Int32.TryParse(input2, out mass1[i]))
//                {

//                }
//                else
//                {
//                    Console.WriteLine("Некорректный ввод");
//                    i--;
//                }
//            }

//            //int[] mass2 = new int[length];




//            int right = length % 2 == 0 ? length / 2 : length / 2 + 1;

//            for (int i = 0; i < length / 2; i++)
//            {
//                int temp = mass1[i];
//                mass1[i] = mass1[right + i];
//                mass1[right + i] = temp;
//            }

//            Console.WriteLine(string.Concat(mass1));
//        }
//    }
//    }













//-----------------------------------------------------------------
//using System;  // 10. реверс массива
//using System.Collections.Generic;
//using System.Linq;

//namespace ConsoleApp13
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] mass1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//            int[] mass2 = new int[10];



//            for (int i = 9; i >= 0; i--)
//            {
//                mass2[i] = mass1[i];
//                Console.WriteLine(mass2[i]);
//            }

//        }

//    }
//}










//----------------------------------------------------------------
//using System;  // 10. число Фибоначи
//using System.Collections.Generic;
//using System.Linq;

//namespace ConsoleApp13
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] mass = new int[20];
//            mass[0] = 0;
//            mass[1] = 1;


//            for (int i = 2; i < 20; i++)
//            {
//                mass[i] = mass[i - 1] + mass[i - 2];
//            }

//            for (int i = 0; i < 20; i++)
//            {
//                Console.WriteLine(mass[i]);
//            }
//        }

//    }
//}

//-------------------------------------------------------------


//using System;  // 5. Посчитать сумму элементов массива с нечетными индексами.

//namespace ConsoleApp13
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int length;

//            for (; ; )
//            {
//                Console.WriteLine("Enter length");

//                string input = (Console.ReadLine());

//                if (Int32.TryParse(input, out length) && length > 0)
//                {
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Некорректный ввод");
//                    continue;
//                }

//            }

//            int[] numbers = new int[length];

//            for (int i = 0; i < length; i++)
//            {
//                Console.WriteLine($"Enter {i} number");

//                string input2 = (Console.ReadLine());

//                if (Int32.TryParse(input2, out numbers[i]))
//                {

//                }
//                else
//                {
//                    Console.WriteLine("Некорректный ввод");
//                    i--;
//                }
//            }


//            int sumOdd = 0;

//            for (int i = 0; i < length; i++) 
//            {
//                if (i % 2 != 0)
//                {
//                    sumOdd += numbers[i];
//                }
//            }

//            Console.WriteLine($"Сумма элементов массива с нечетными индексами = {sumOdd}");

//        }
//    }
//}



//------------------------------------------------------------------------------
//using System;             //7. Посчитать количество нечетных элементов массива.

//namespace ConsoleApp13
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int length;

//            for (; ; )
//            {
//                Console.WriteLine("Enter length");

//                string input = (Console.ReadLine());

//                if (Int32.TryParse(input, out length) && length > 0)
//                {
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Некорректный ввод");
//                    continue;
//                }

//            }

//            int[] numbers = new int[length];

//            for (int i = 0; i < length; i++)
//            {
//                Console.WriteLine($"Enter {i} number");

//                string input2 = (Console.ReadLine());

//                if (Int32.TryParse(input2, out numbers[i]))
//                {

//                }
//                else
//                {
//                    Console.WriteLine("Некорректный ввод");
//                    i--;
//                }
//            }


//            int count = 0;

//            for (int i = 0; i < length; i++) 
//            {
//                if (numbers[i] % 2 != 0)
//                count++;
//            }

//            Console.WriteLine($"количество нечетных элементов массива = {count}");

//        }
//    }
//}

//-------------------------------------------------------------------------------
//using System;                     //индекс минимального и максимального массива

//namespace ConsoleApp13
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int length;

//            for (; ; )
//            {
//                Console.WriteLine("Enter lenght");

//                string input = (Console.ReadLine());

//                if (Int32.TryParse(input, out length) && length > 0)
//                {
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Некорректный ввод");
//                    continue;
//                }

//            }

//            int[] numbers = new int[length];

//            for (int i = 0; i < length; i++)
//            {
//                Console.WriteLine($"Enter {i} number");

//                string input2 = (Console.ReadLine());

//                if (Int32.TryParse(input2, out numbers[i]))
//                {

//                }
//                else
//                {
//                    Console.WriteLine("Некорректный ввод");
//                    i--;
//                }
//            }

//            int min = numbers[0];
//            int minIndex = 0;

//            int max = numbers[0];
//            int maxIndex = 0;


//            for (int i = 0; i < length; i++)
//            {
//                if (min > numbers[i])
//                {
//                    min = numbers[i];
//                    minIndex = i;
//                }
//                if (max < numbers[i])
//                {
//                    max = numbers[i];
//                    maxIndex = i;
//                }


//            }

//            Console.WriteLine($"minimal index is {minIndex}");
//            Console.WriteLine($"maximal index is {maxIndex}");
//        }
//    }
//}




//-------------------------------------------------------------------------------------
//using System;            //минимальный и максимальный элемент массива

//namespace ConsoleApp13
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int length;

//            for (; ; )
//            {
//                Console.WriteLine("Enter lenght");

//                string input = (Console.ReadLine());

//                if (Int32.TryParse(input, out length)&& length>0)
//                {
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Некорректный ввод");
//                    continue;
//                }

//            }

//            int[] numbers = new int[length];

//            for (int i = 0; i < length; i++)
//            {
//                Console.WriteLine($"Enter {i} number");

//                string input2 = (Console.ReadLine());

//                if (Int32.TryParse(input2, out numbers[i]))
//                {

//                }
//                else
//                {
//                    Console.WriteLine("Некорректный ввод");
//                    i--;
//                }
//            }

//            int minValue = numbers[0];
//            int maxValue = numbers[0];

//            for (int i = 1; i < length; i++)
//            {
//                if (minValue > numbers[i])
//                {
//                    minValue = numbers[i];

//                }
//                if (maxValue < numbers[i])
//                {
//                    maxValue = numbers[i];

//                }

//            }

//            Console.WriteLine($"minimal value is {minValue}");
//            Console.WriteLine($"maximal value is {maxValue}");





//        }
//    }
//}





































