using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace updateCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<char> characters = new List<char>();
                characters.AddRange(new char[] { 'a', 'b', 'c', 'd', 'e', 'f' });

                if (characters.Count >= 7)
                {
                    char value = characters[6];
                    Console.WriteLine(value);
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
