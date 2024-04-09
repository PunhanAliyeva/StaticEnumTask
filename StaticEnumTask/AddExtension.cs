using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticEnumTask
{
    static class AddExtension
    {
       public static int[] Add(this int[] arr, int num)     
        {
            int[]array=new int[arr.Length+1];         
            for (int i = 0; i < arr.Length; i++)
            {
                array[i] = arr[i];
            }
            array[arr.Length] = num;
            return array;
        }
    }
}
