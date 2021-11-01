using System;
using System.IO;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerenciamento g = new Gerenciamento();

            TextReader leitor = System.Console.In;
            TextWriter escritor = System.Console.Out;
            float aux = 1;
            while (aux != 0)
            {
                Console.WriteLine("Escolha uma opção do menu :\n");
                Console.WriteLine(" [1] - Inserir Container");
                Console.WriteLine(" [2] - Remover Container");
                Console.WriteLine(" [3] - Imprimir todos elementos da pilha");
                Console.WriteLine(" [4] - Sair");

                string op = leitor.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.Write("Digite o container a ser inserido:\n");
                        String icontainer = leitor.ReadLine();
                        int icodigo = Convert.ToInt32(icontainer);
                        g.insereContainer(icodigo);
                        Console.Write("\nAperte enter para continuar");
                        leitor.ReadLine();
                        Console.Clear();
                        break;

                    case "2":
                        Console.Write("Digite o container a ser removido:\n");
                        String rcontainer = leitor.ReadLine();
                        int rcodigo = Convert.ToInt32(rcontainer);
                        g.tiraContainer(rcodigo);
                        Console.Write("\nAperte enter para continuar");
                        leitor.ReadLine();
                        Console.Clear();
                        break;

                    case "3":
                        g.print();
                        Console.Write("\nAperte enter para continuar");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "4":
                        aux = 0;
                        Console.Clear();
                        break;
                    default:
                        Console.Write("Favor selecionar uma das opções mostradas no menu\n");
                        break;
                }


            }
        }

    }
}
