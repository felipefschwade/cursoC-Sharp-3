using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade5ConsoleAplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá C# ");
            while(true)
            {
                Console.WriteLine("Escreva alguma coisa ");
                using (Stream entrada = Console.OpenStandardInput())
                using (TextReader leitor = new StreamReader(entrada))
                {
                    var linha = leitor.ReadLine();
                    if (linha != null)
                    {
                        Console.WriteLine("Você escreveu:");
                        Console.WriteLine(linha);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
