using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_3
{
    class Func
    {
            public double Length(double r)
            {
            if (r >= 0)
            {
                return 2 * Math.PI * r;
            }
            else
            {
                throw new FormatException("Invalid input data");
            }
            }

            public double Square(double r)
            {
            if (r >= 0)
            {
                return Math.PI * r * r;
            }
            else
            {
                throw new FormatException("Invalid input data");
            }
            }
            public double Volume(double r)
            {
            if (r >= 0)
            {
                return (4.0 / 3.0) * Math.PI * r * r * r;
            }
            else
            {
                throw new FormatException("Invalid input data");
            }
            }
        }
    }

