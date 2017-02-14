using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parcial1Ap1_AnthonySP
{
   public class Utilidades
    {
       
        
            public static int TOINT(string Numero)
            {
                int retorno = 0;

                int.TryParse(Numero, out retorno);

                return retorno;
            }
        }

    }

