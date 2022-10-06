using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuffle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.Write("Массив до перемешивания: ");
            WriteArray(array);
            array = Shuffle(array);
            Console.Write("\nМассив после перемешивания: ");
            WriteArray(array);
            Console.ReadLine();
        }

        static void WriteArray(int[] array)
        {
            Console.Write("|");

            foreach(var element in array)
            {
                Console.Write(element + "|");
            }
        }

        static int[] Shuffle(int[] array)
        {
            Random random = new Random();
            
            for(int i = 0; i < array.Length - 1; i++)
            {
                int index = random.Next(i + 1);
                int tempValue = array[i];

                array[i] = array[index];
                array[index] = tempValue;
            }

            return array;
        }
    }
}
