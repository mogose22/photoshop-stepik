using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public struct Pixel
    {
        public Pixel(double r, double g, double b)
        {
            //Хак для того, чтобы использовать свойства внутри конструктора
            this.r = this.b = this.g = 0;

            R = r;
            G = g;
            B = b;
        }
        public double Check(double value)
        {
            if (value > 1 || value < 0) 
                throw new ArgumentException();
            return value;
        }

        private double r;
        private double g;
        private double b;
        public double R 
        {
            get { return r; }
            set { r = Check(value); } 
        }
        public double G 
        { 
            get { return g; }
            set { g = Check(value); }
        }
        public double B 
        { 
            get { return b; }
            set { b = Check(value); }
        }
    }
}
