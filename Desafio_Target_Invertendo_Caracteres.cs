using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio Target");
            Console.WriteLine("--------------");
            Console.WriteLine("Digite sua frase desejada o programa irá lhe informar a quantidade de caracteres" +
                " e irá lhe apresentar de trás para frente!");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            
            string palavra = Console.ReadLine();
            Console.WriteLine(palavra.Length); /*Conta quantos Char tem*/
            for (int i = 0; i < palavra.Length; i++)
            {
                Console.Write(palavra[palavra.Length - i - 1]);
            }
            

                       
            Console.ReadKey();

        }
            
            

        
       
    }
}
