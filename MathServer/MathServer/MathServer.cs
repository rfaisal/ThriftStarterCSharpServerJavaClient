using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math
{
    public class MathServer : Math.MathService.Iface
    {
        public MathServer() { }
        public int add(int a, int b)
        {
            Console.WriteLine("Called add({0},{1})={2}", a, b, a+b);
            return a + b;
        }
        public int sub(int a, int b)
        {
            Console.WriteLine("Called sub({0},{1})={2}", a, b, a - b);
            return a - b;
        }
        public int mul(int a, int b)
        {
            Console.WriteLine("Called mul({0},{1})={2}", a, b, a * b);
            return a * b;
        }
        public int div(int a, int b)
        {
            Console.WriteLine("Called div({0},{1})={2}", a, b, a / b);
            return a / b;
        }
        public int mod(int a, int b)
        {
            Console.WriteLine("Called mod({0},{1})={2}", a, b, a % b);
            return a % b;
        }
    }
}
