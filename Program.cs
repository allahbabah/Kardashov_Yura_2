    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kp2
{
    partial class Program
    {
        static void Main(string[] args)
        {
            ArrayMethod arrayMethods = new ArrayMethod();
            int[] array = arrayMethods.Create(10);
            int[] array2 = arrayMethods.Create(3);
            arrayMethods.Show(array);
            Console.WriteLine();
            arrayMethods.Show(array2);
            arrayMethods.Array = array;
            arrayMethods.IndexNumber = 3;
            Console.WriteLine(arrayMethods.IndexNumber);
            arrayMethods.ShowByIndex(array, 3);
            int[] unite = arrayMethods.Unite(array, array);
            arrayMethods.Show(unite);
            int[] uniteNoRepeat = arrayMethods.UniteNoRepeat(array2, array);
            arrayMethods.Show(uniteNoRepeat);
            

        }
    }
}
