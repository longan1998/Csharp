using System;

namespace Assigment6
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] RateList = { 1, 2, 3 };
            New test = new New(1, "Test", "12/12/1222", "Abc", "Tôi không biết đây là gì", RateList);
            test.Calculate();
            test.Display();
        }
    }
}