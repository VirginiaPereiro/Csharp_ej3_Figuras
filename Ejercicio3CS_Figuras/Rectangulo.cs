using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3CS_Figuras
{
    public class Rectangulo:Figuras
    {
        public double H { get; set; }
        public double B { get; set; }

        public Rectangulo(double b, double h,String descripcion, String nombre = "Rectángulo")
            :base(nombre,descripcion)
        {
            B = b;
            H = h;
        }

        public override double Area()
        {
            var area = B*H;
            return area;
        }

        public override double Perimetro()
        {
            var perimetro = (2*B) + (2*H);
            return perimetro;
        }
    }
}
