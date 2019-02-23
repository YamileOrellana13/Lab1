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
        public clsSuma suma(int numero1, int numero2)
        {
            clsSuma obj = new clsSuma();
            obj.numeroA = numero1;
            obj.numeroB = numero12;
            obj.resultado = obj.numeroA + obj.numeroB;
            return obj;
        }
    }
}
