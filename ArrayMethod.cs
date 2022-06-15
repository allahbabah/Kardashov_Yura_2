using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kp2
{
    class ArrayMethod
    {
        Random random = new Random();
        private int[] array;
        private int index;

        public int[] Array
        {
            set { array = value; }
        }

        public int IndexNumber
        {
            set 
            {
                if (value < array.Length)
                {
                    index = value;
                }
                else
                {
                    index = -1;
                    Exception("Индекс за пределами массива");
                }
            }
            get 
            {
                if (index < array.Length&&index != -1)
                {
                    return array[index];
                }
                else
                {
                    return -1;
                }
            }
        }

        public void Show(int[] array)
        {
            Console.WriteLine("----------------------------------------------");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("----------------------------------------------");
        }

        public void ShowByIndex(int[] array, int index)
        {
            Console.WriteLine();
            Console.WriteLine("Index "+index +" : "+array[index]);
            Console.WriteLine();
        }

        public int[] Unite(int[] array, int[] array2)
        {
            int[] result = new int[array.Length + array2.Length];
            int n = array.Length > array2.Length ? array2.Length : array.Length;
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                result[k++] = array[i];
                result[k++] = array2[i];
            }
            if (array.Length == array2.Length)
            {
                return result;
            }
            else
            {
                for (int i = 0; i < Math.Abs(array.Length - array2.Length); i++)
                {
                    if (array.Length > array2.Length)
                    {
                        result[k++] = array[n++];
                    }
                    else
                    {
                        result[k++] = array2[n++];
                    }
                }
                return result;
            }
        }

        public int[] UniteNoRepeat(int[] array, int[] array2)
        {
            int[] result = Unite(array ,array2);
            result = result.Distinct().ToArray();
            return result;
        }

        public int[] Create(int a)
        {
            int[] result = new int[a];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = random.Next(50);
            }
            return result;
        }

        private void Exception(string text)
        {
            Console.WriteLine(text);
        }
        
    }
}
