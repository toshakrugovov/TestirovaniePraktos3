using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscriminantCheck
{
    public class Discriminant
    {
        public double[] Nahozdeniekorney(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                return new double[0]; 
            }
            else if (discriminant == 0)
            {
                return new double[] { -b / (2 * a) };
            }
            else
            {
                return new double[]
                {
                    (-b + Math.Sqrt(discriminant)) / (2 * a),
                    (-b - Math.Sqrt(discriminant)) / (2 * a)
                };
            }
    
        }
        public double Procentotchisla(double chislo, double procent)
        {
            return (chislo * procent) / 100;
        }
    }
}
