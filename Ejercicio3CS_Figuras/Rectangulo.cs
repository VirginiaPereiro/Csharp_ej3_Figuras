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

        public override void PrintDetalle(string separador = " ")
        {
            /*Console.WriteLine("Figura " + separador + Nombre +
                separador + H + separador + separador + B + Area());*/

            String[] datos = {Nombre, B.ToString(), H.ToString(), Area().ToString()};
            var texto = String.Join(separador, datos);
            
            Console.WriteLine(texto);
        }

      
        public override string GetDetalle()
        {
            return String.Format("Figura {0} {1} {2} {3}", Nombre, H, B, Area());
        }
    }
}
