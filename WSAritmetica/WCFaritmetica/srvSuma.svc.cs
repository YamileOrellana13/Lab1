using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFaritmetica
{

    public class srvSuma : IsrvSuma
    {
        public ClsSuma suma(int numero1, int numero2)
        {
            ClsSuma obj = new ClsSuma();
            obj.numeroA = numero1;
            obj.numeroB = numero2;
            obj.resultado = obj.numeroA + obj.numeroB;
            obj.mensaje = "Suma Satisfactoria";
            if (obj.resultado < 0)
                obj.error = "Resultado Negativo";
            return obj;
        }
    }
}
