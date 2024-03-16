using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Software = new string[4];

            Software[0] = "C#";
            Software[1] = "C++";
            Software[2] = "Java";
            Software[3] = "Phyton";

            for (int i = 0; i < Software.Length; i++)
            {
                Console.WriteLine(Software[i]);
            }
            Console.ReadLine();
        }
    }
}
