using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortingarrayelement_dec_or_ase_inanarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter the array element");
            for(int i=0;i<5;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0;i<5; i++)
            {
                for(int j=0;j<5;j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            Console.WriteLine("sort array element in decending order");
            for(int i=0;i<5;i++)
            {
                Console.WriteLine(arr[i]);
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            Console.WriteLine("sort array element in asending order");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
