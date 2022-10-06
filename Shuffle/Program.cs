﻿using System;
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
            int[] tempArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                bool isFind = false;
                
                while(isFind == false)
                {
                    int index = random.Next(0, array.Length);

                    if (tempArray[index] == 0)
                    {
                        tempArray[index] = array[i];
                        isFind = true;
                    }
                }
            }

            return tempArray;
        }
    }
}