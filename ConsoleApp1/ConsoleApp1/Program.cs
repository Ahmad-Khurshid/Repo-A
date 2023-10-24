using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public delegate int  MathOperation<T>(int num1, int num2);
        public static int Add(int num1,int num2)
        {
            return num1 + num2;
        } 
         
        static void Main(string[] args)
        {
            MathOperation<int> obj = Add;
            Console.WriteLine(obj(2,3));
            Console.ReadLine();
        } 
    }
}
