using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao2
{
    class Pilha
    {
        // atributos 
        private Noh topo;

        // metodos
        public Pilha()
        {
            topo = null; // não foi inserido elemento
        }

        public bool isEmpty()
        {
            if (topo == null)
                return true;
            else
                return false;
        }

        public void push(int insertItem)
        {
            if (isEmpty())
                topo = new Noh(insertItem);
            else
            {
                // NohPilha novoNoh = new NohPilha(insertItem, topo); OU
                Noh novoNoh = new Noh(insertItem);
                novoNoh.setAnterior(topo);

                topo = novoNoh; // o topo agora aponta para mim -- this
            }
        } // fim do método push



        public int pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Pilha Vazia");
                return 0;
            }
            else
            {
                int temp = topo.getData();
                topo = topo.getAnterior();
                return (temp);
            }

        }

        public void print()
        {
            if (isEmpty())
                Console.WriteLine("Pilha Vazia");
            else
            {
                Console.WriteLine("Status atual da Pilha:");
                Noh temp = topo;

                while (temp != null)
                {
                    Console.WriteLine("\n" + temp.getData());
                    temp = temp.getAnterior();
                } // fim do while
            } // fim do else 
        } // fim do método print
    }
}
