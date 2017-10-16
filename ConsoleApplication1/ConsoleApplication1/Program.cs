using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Computer a = new Computer();
            try
            {
                Console.WriteLine("请输入x:");
                string A = Console.ReadLine();
                a.X = double.Parse(A);
            }
            catch (Exception m)
            {
                Console.WriteLine("请输入正确的数字！");
            }
            try
            {
                Console.WriteLine("请输入y:");
                string B = Console.ReadLine();
                a.Y = double.Parse(B);
            }
            catch (Exception m)
            {
                Console.WriteLine("请输入正确的数字！");
            }
            try
            {
                Console.WriteLine("请输入运算符:");
                string C = Console.ReadLine();
                a.N = char.Parse(C);
            }
            catch (Exception m)
            {
                Console.WriteLine("请输入正确运算符！");
            }
            a.Count();
            Computer f = new Computer();
            Console.WriteLine("请输入第一个字符串:");
            string G = Console.ReadLine();
            Console.WriteLine("请输入第二个字符串:");
            string H = Console.ReadLine();
            Console.WriteLine("请输入运算符:");
            string V = Console.ReadLine();
            f.K = G;
            f.L = H;
            f.S = char.Parse(V);
            f.Count1();
        }
    }

    class Computer
    {
        private double x;

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        private double y;

        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        private char n;

        public char N
        {
            get { return n; }
            set { n = value; }
        }
        private string k;

        public string K
        {
            get { return k; }
            set { k = value; }
        }
        private string l;

        public string L
        {
            get { return l; }
            set { l = value; }
        }
        private char s;

        public char S
        {
            get { return s; }
            set { s = value; }
        }
        public void Count()
        {
            switch (n)
            {
                case '+': Console.WriteLine(x + y); break;
                case '-': Console.WriteLine(x - y); break;
                case '*': Console.WriteLine(x * y); break;
                case '/':
                    if (y != 0)
                        Console.WriteLine(x / y);
                    else
                        Console.WriteLine("除数不能为0！");
                    break;
                default:
                    Console.WriteLine("请输入正确的运算符！"); break;
            }
        }
        public void Count1()
        {
            switch (s)
            {
                case '+':
                    StringBuilder MyStringBuilder = new StringBuilder();
                    MyStringBuilder.Append(k);
                    MyStringBuilder.Append(l);
                    string H = MyStringBuilder.ToString();
                    Console.WriteLine(H); break;

                case '-':
                    string T = k.Remove(k.LastIndexOf(l));
                    Console.WriteLine(T);
                    break;
                default:
                    Console.WriteLine("请输入正确的运算符！"); break;

            }
        }
    }
}