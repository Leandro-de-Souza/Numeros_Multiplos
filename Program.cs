using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBLEMA_MULTIPLOS {
    internal class Program {
        static void Main(string[] args) {

            int numero1, numero2;

            Console.WriteLine("Digite dois numeros inteiros: ");
            numero1 = int.Parse(Console.ReadLine());
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 % numero2 == 0 || numero2 % numero1 == 0) {
                Console.WriteLine("Sao multiplos");
            }
            else {
                Console.WriteLine("Nao sao multiplos");
            }

        }
    }
}
