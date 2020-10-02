using System;
using System.Text;

namespace Xây_dựng_lớp_QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập c: ");
            double c = double.Parse(Console.ReadLine());
            QuadraticEquation qe = new QuadraticEquation(a, b, c);

            if (qe.GetDiscriminant() > 0)
            {
                Console.WriteLine("Phương trình có 2 nghiệm x1 = {0}, x2 = {1}: ", qe.GetRoot2x1(), qe.GetRoot2x2());
            }
            else if (qe.GetDiscriminant() == 0)
            {
                Console.WriteLine("Phương trình có một nghiệm duy nhất: " + qe.GetRoot1());
            }
            else
                Console.WriteLine("Phương trình vô nghiệm");
        }
    }
}