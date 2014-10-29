using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3CS_Figuras
{
    public interface IDetallable
    {
        //métodos 
        void PrintDetalle(string separador = "");
        string GetDetalle();

    }
}
