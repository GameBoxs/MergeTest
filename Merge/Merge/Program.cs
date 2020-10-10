using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge
{
    class Program
    {
        static int calculate(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("a와 b의 계산은 :{0}입니다.", calculate(5, 5));
        }
    }
}
