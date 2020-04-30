using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {
        public static int sum(int a, int b) {
            return a + b;
        }
        public static int div(int a, int b) {
            return a - b;
        }
        public static void Main() {
            Console.WriteLine("Hello world");
            Console.WriteLine(sum(3, 5));
            Console.WriteLine(div(3, 5));
            Console.ReadLine();
        }
    }
}
