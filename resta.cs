using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo3
{
    public class resta : Operaciones

    {
        public int operar()
        {
            resultado = valor1 - valor2;
            return resultado;
        }
    }
}
