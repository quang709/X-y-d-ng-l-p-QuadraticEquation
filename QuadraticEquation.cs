using System;
using System.Collections.Generic;
using System.Text;

namespace Xây_dựng_lớp_QuadraticEquation
{
    class QuadraticEquation
    {
        private double a { set; get; }
        private double b { set; get; }
        private double c { set; get; }

        public QuadraticEquation()
        {

        }
        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double GetDiscriminant()
        {
            double delta;
            return delta = b * b - (4 * a * c);
        }
        public double GetRoot1()
        {
            return -b / (2 * a);
        }
        public double GetRoot2x1()
        {
            return (-b + Math.Pow(GetDiscriminant(), 0.5)) / (2 * a);
        }

        public double GetRoot2x2()
        {
            return (-b - Math.Pow(GetDiscriminant(), 0.5)) / (2 * a);
        }
    }
}