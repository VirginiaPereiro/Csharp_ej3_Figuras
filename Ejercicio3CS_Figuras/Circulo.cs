using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3CS_Figuras
{
    public class Circulo:Figuras
    {
        public double R { get; set; }

        public Circulo(double r, String descripcion, String nombre = "Circulo")
            :base(nombre,descripcion)
        {

            R = r;
        }

        public override double Area()
        {
            var area = Math.PI*Math.Pow(R, 2);
            return area;
        }

        public override double Perimetro()
        {
            var perimetro = 2*Math.PI*R;
            return perimetro;
        }
    }
}
