using System;

namespace _4._1_черт_побери
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int rez = 0;
            char c;

            Console.WriteLine("Введите а и b, или выберите операцию: +, -, *, /");
            c = Convert.ToChar(Console.ReadLine());
            switch (c)
            {
                case '*': rez = a * b; break;
            }
            Console.Write(rez);
            Console.ReadKey();
        }
    }
}
