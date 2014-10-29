using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3CS_Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
         /* FORMA FÁCIL
          * 
          * Figuras rect1 = new Rectangulo(4.5, 8, "mi rectangulo");
            Figuras rect2 = new Rectangulo(2.5, 6.2, "mi rectangulo");
            Figuras rect3 = new Rectangulo(1.2, 4.1, "mi rectangulo");

            Figuras c1 = new Circulo(3.1, "mi círculo");
            Figuras c2 = new Circulo(5.1, "mi círculo");
            Figuras c3 = new Circulo(6.8,"mi círculo");
            
            var a1 = c3.Area();

            Figuras[] figuras=new Figuras[6];

            figuras[0] = rect1;
            figuras[1] = rect2;
            figuras[2] = rect3;
            figuras[3] = c1;
            figuras[4] = c2;
            figuras[5] = c3;
            
            for (int i = 0; i < figuras.Length; i++)
            {
                var area =figuras[i].Area();
                Console.WriteLine(area);
            }

            Console.ReadLine();*/

            Console.Write("¿Cuántas figuras quieres introducir?");
            int tamanyoArray;
            int.TryParse(Console.ReadLine(), out tamanyoArray);
            
            var figurasConsola = new Figuras[tamanyoArray];

            for (int i = 0; i < figurasConsola.Length; i++)
            {
                Console.Write("¿Círculo o rectángulo?");
                String tipo="";
                tipo = Console.ReadLine();

                if (tipo == "circulo")
                {
                    figurasConsola[i]=crearCirculo();
                }

                else if (tipo == "rectangulo")
                {
                    figurasConsola[i] = crearRectangulo();
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }

            for (int i = 0; i < figurasConsola.Length; i++)
            {
                var area= figurasConsola[i].Area();
                Console.WriteLine((i+1)+". "+figurasConsola[i].Nombre);
                Console.WriteLine(" " + figurasConsola[i].Descripcion);
                Console.WriteLine("Area: {0:N}", area);// {0:N} para que redondee a dos decimales
            }

            Console.ReadLine();


            //CON INTERFACE
            //más genérico, para instanciar el objeto
            IDetallable[] f;
            f=new IDetallable[tamanyoArray];

            foreach (var figura in f)
            {
                figura.PrintDetalle("-");
            }

            Console.ReadLine();

        }

        //el usurio mete por pantalla el radio para calcular el área y perímetro de la circunferencia

        public static Figuras crearCirculo()
        {
            Console.Write("radio");
            var r = 0.0;
            double.TryParse(Console.ReadLine(), out r);
            Console.Write("descripcion");
            var descrip=Console.ReadLine();

            return new Circulo(r, descrip);
        }

        //el usuario mete por pantalla el alto y ancho del rectángulo

        public static Figuras crearRectangulo()
        {
            Console.Write("Base");
            var b = 0.0;
            double.TryParse(Console.ReadLine(), out b);

            Console.Write("Altura");
            var h = 0.0;
            double.TryParse(Console.ReadLine(), out h);

            Console.Write("descripcion");
            var descrip = Console.ReadLine();

            return new Rectangulo(b, h,descrip);
        }
    }
}
