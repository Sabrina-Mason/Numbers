using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Reversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int numb = int.Parse(Console.ReadLine());
            int reverse = 0;
            while (numb > 0)
            {
                int rem = numb % 10;
                reverse = (reverse * 10) + rem;
                numb = numb / 10;
                // I think im going to enjoy working with C#
                // Google has been my friend
                // Google cares about me
                // I hope these comments made you smile
            }
            Console.WriteLine("Reverse number={0}", reverse);
            Console.ReadLine();


        }
    }
}
