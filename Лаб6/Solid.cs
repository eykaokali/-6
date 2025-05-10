using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб6
{
    internal abstract class Solid
    {
        public abstract double GetVolume();
    }
    internal class Pyramid: Solid
    {
        private double a;
        private double h;
        public double A
        {
            get { return a; }
            set 
            {
                if (value >= 0)
                {
                    a = value;
                }
            }
        }
        public double H
        {
            get { return h; }
            set
            {
                if (value >= 0)
                {
                    h = value;
                }
            }
        }
        public override double GetVolume() 
        {
            return 1.0/3 * a * a * h;
        }
    }
     internal class Cone: Solid
    {
        private double r;
        private double h;

        public double R
        {
            get { return r; }
            set
            {
                if (value >= 0)
                {
                    r = value;
                }
            }
        }
        public double H
        {
            get { return h; }
            set
            {
                if (value >= 0)
                {
                    h = value;
                }
            }
        }

        public override double GetVolume()
        {
            return 1.0/3 * r * r * h;
        }
    }
}
