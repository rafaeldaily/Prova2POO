using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao1
{

    
    class Gerenciamento
    {
        private Pilha[] local;

        public Gerenciamento()
        {
            local = new Pilha[4];
            for (int x = 0; x < 4; x++)
            {
                local[x] = new Pilha();
            }
        }

        public Pilha menorPilha()
        {
            Pilha menor = local[1];
            for (int x = 0; x < 4; x++)
            {
                if (local[x].count() < menor.count())
                {
                    menor = local[x];
                }
            }

            return menor;
        }

        public Boolean haContainer(int codigo)
        {
            for (int x = 0; x<4; x++)
            {
                if (local[x].haElemento(codigo))
                {
                    return true;
                }
            }

            return false;
        }

        public void insereContainer(int codigo)
        {
            Pilha menor = menorPilha();
            if (menor.count()>=3)
            {
                Console.WriteLine("Impossível empilhar! Não é mais possível adicionar containers nas pilhas. Os locais estão cheios");
            }else if (haContainer(codigo))
            {
                Console.WriteLine("Código invalido! : O código já existe");
            }
            else
            {
                menor.push(codigo);
                Console.Write("Elemento inserido!");
            }
            
        }

        public void tiraContainer(int codigo)
        {
            if (!haContainer(codigo))
            {
                Console.WriteLine("Código invalido! : O código não existe");
            }
            else if (local[0].getValorTopo()!=codigo&& local[1].getValorTopo() != codigo && local[2].getValorTopo() != codigo && local[3].getValorTopo() != codigo)
            {
                Console.WriteLine("Impossível desempilhar! : não é possível remover o container, ele não esta no topo da pilha") ;
            }
            else
            {
                for (int x = 0; x < 4; x++)
                {
                    if (local[x].getValorTopo()==codigo)
                    {
                        local[x].pop();
                        Console.Write("Elemento removido!");
                        break;
                    }
                }
            }
            
        }

        public void print()
        {
            for (int x = 0; x < 4; x++)
            {
                int mostra = x + 1;
                Console.WriteLine("\nLocal: " + mostra);
                local[x].print();               
            }
        }
    }
}
