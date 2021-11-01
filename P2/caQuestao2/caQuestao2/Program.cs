using System;
using System.IO;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fila fila = new Fila();


            TextReader leitor = System.Console.In;
            TextWriter escritor = System.Console.Out;
            float aux = 1;
            while (aux != 0)
            {
                Console.WriteLine("Escolha uma opção do menu :\n");
                Console.WriteLine(" [1] - Inserir elemento na fila");
                Console.WriteLine(" [2] - Remover elemento da fila");
                
                Console.WriteLine(" [3] - insira um inteiro apos outro ser escolhido");
                Console.WriteLine(" [4] - reverte a fila");
                Console.WriteLine(" [5] - Imprimir todos elementos da fila");
                Console.WriteLine(" [6] - Sair");

                string op = leitor.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.Write("Digite o elemento a ser inserido:\n");
                        String elemento = leitor.ReadLine();
                        int valor = Convert.ToInt32(elemento);
                        fila.insere(valor);
                        Console.Clear();
                        break;

                    case "2":
                        Console.Write("Um elemento  foi removido");
                        Console.WriteLine("Removeu o " + fila.retirar());
                        Console.Clear();
                        break;

                    case "5":
                        Console.Write("A Fila encontra-se na seguinte disposição :\n");
                        fila.imprime();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "3":
                        Console.Write("Digite o elemento a ser inserido:\n");
                        String elemento1 = leitor.ReadLine();
                        int valor1 = Convert.ToInt32(elemento1);
                        Console.Write("Digite o posicao a ser inserido:\n");
                        String pos = leitor.ReadLine();
                        int p = Convert.ToInt32(pos);
                        fila.furafila(valor1, p);
                        Console.Clear();
                        break;

                    case "6":
                        aux = 0;
                        Console.Clear();
                        break;

                    case "4":
                        Console.Write("A pilha reverteu \n");
                        fila.reverte();
                        Console.ReadLine();
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
