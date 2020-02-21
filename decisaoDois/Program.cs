using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decisaoDois
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o número");
            String numero = Console.ReadLine();

            if (numero == "1") {
                Console.WriteLine("Muito Insuficiente!");
            }else if (numero == "2"){
                Console.WriteLine("Insuficiente!");
            }else if (numero == "3"){
                Console.WriteLine("Suficiente!");
            }else if(numero == "4"){
                Console.WriteLine("Bom!");
            }else if(numero == "5") {
                Console.WriteLine("Muito bom!");
            }else{
                Console.WriteLine("Valor invalido!");
            }

            Console.ReadKey();
        }
    }
}
