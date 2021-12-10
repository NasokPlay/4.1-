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
                case 'a':
                    Console.WriteLine("Введите а");
                    a = Convert.ToInt32(Console.ReadLine()); break;
                case 'b':
                    Console.WriteLine("Введите b");
                    b = Convert.ToInt32(Console.ReadLine()); break;

                case '+': rez = a + b; break;
                case '-': rez = a - b; break;

                case '*': rez = a * b; break;

            }
            Console.Write(rez);
            Console.ReadKey();
        }
    }
}
