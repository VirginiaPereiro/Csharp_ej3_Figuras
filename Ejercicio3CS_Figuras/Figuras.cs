using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3CS_Figuras
{
    public abstract class Figuras:IDetallable 
    {
        public String Nombre { get; set; }
        public String Descripcion { get; set; }

        protected Figuras(String nombre,String descripcion)
            // protected por la herencia, porque no se va a instanciar
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public abstract double Area();
        public abstract double Perimetro();
        
        //implementado de forma abstracta de forma implícita
        public abstract void PrintDetalle(string separador = " ");
        public abstract String GetDetalle();

    }
}
