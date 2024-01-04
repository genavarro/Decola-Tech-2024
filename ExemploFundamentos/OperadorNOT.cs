using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos
{
    public class OperadorNOT
    {
        //Operador NOT (!)
        public void TestarOperadorNOT()
        {
            bool choveu = false;
            bool estaTarde = false;

            if (!choveu && !estaTarde)
            {
                Console.WriteLine("Vou pedalar");
            }
            else
            {
                Console.WriteLine("Vou pedalar outro dia");
            }
        }

    }


}
