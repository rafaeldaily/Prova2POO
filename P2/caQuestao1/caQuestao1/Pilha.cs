using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao1
{
    class Pilha
    {
        // atributos 
        private NohPilha topo;

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
                topo = new NohPilha(insertItem);
            else
            {
                // NohPilha novoNoh = new NohPilha(insertItem, topo); OU
                NohPilha novoNoh = new NohPilha(insertItem);
                novoNoh.setNext(topo);

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
                topo = topo.getNext();
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
                NohPilha temp = topo;

                while (temp != null)
                {
                    Console.WriteLine("\n" + temp.getData());
                    temp = temp.getNext();
                } // fim do while
            } // fim do else 
        } // fim do método print

        public int count()
        {
            if (isEmpty())
                return 0;
            else
            {
                int i = 0;
                NohPilha temp = topo;

                while (temp != null)
                {
                    i++;
                    temp = temp.getNext();
                } // fim do while
                return i;
            } // fim do else 
        } // fim do método print

        public Boolean haElemento(int item)
        {
            if (isEmpty())
                return false;
            else
            {
                NohPilha temp = topo;

                while (temp != null)
                {
                    if (item==temp.getData())
                    {
                        return true;
                    }
                    temp = temp.getNext();
                } // fim do while
                return false;
            } // fim do else 

        }

        public int getValorTopo()
        {
            return topo.getData();
        }

    }
}
