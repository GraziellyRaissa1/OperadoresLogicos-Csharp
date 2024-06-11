using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresLogicosCsharp
{
    internal class OperadorNAO
    {
        public static void Main(string[] args)
        {
            int A = 5;

            Console.WriteLine(!(A > 3 && A < 10)); //Retorna falso pois o operador  NÃO = !; é usado para reverter o resultado.
        }
    }
}
