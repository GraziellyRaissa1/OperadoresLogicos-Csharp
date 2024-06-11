using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresLogicosCsharp
{
    internal class OperadorOU
    {
        public static void Main(string[] args)
        {
            int A = 8;

            Console.WriteLine(A > 3 || A < 6); //Retorna verdadeiro porque uma das verificações são verdadeiras por exemplo a variavel A e maior que 3
        }
    }
}
