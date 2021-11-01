using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao2
{
    class Fila
    {
        //atributos
        private Noh start;
        private Noh end;

        //construtor default
        public Fila()
        {
            start = null;
            end = null;
        }

        //função para verificar se esta vazia
        bool isEmpty()
        {
            if (start == null)
                return true;
            else
                return false;

        }

        // 0) Verificar se a fila não está vazia
        // 1) Criar o nó
        // 2) Encadear com o novo nó
        // 3) Fazer FIM (start) apontar para novo nó




        public void insere(int valor)
        {
            Noh novonoh = new Noh(valor); // cria um novo NohFila

            if (isEmpty()) // a Fila está vazia -- primeiro nó da Fila
            {
                start = novonoh; // o start aponta para novonoh
                end = novonoh;   // o end aponta para novonoh
            }
            else
            {
                end.setAnterior(novonoh);
                end = novonoh;
            }

        } // fim do método insere( )

        public void imprime()
        {
            if (isEmpty())
            {
                Console.WriteLine("Fila vazia");
            }
            else
            {
                Noh aux = start;
                while (aux != null)
                {
                    Console.Write(aux.getData() + " ");
                    aux = aux.getAnterior();
                }
            }
        }

        public int count()
        {
            if (isEmpty())
            {
                return 0;
            }
            else
            {
                int i = 0;
                Noh aux = start;
                while (aux != null)
                {
                    i++;
                    aux = aux.getAnterior();
                }
                return i;
            }
        }

        public int retirar()
        {
            if (isEmpty())
            {
                Console.WriteLine("Fila Vazia");
                return 0;
            }

            else
            {
                int aux = start.getData();
                start = start.getAnterior();
                return (aux);

            }
        }

        public void furafila(int valor ,int posicao)
        {
            Fila fila = new Fila();
            while (!isEmpty())
            {
                fila.insere(retirar());
            }
            int i = 0;
            while(i<=posicao)
            {
                if(i != posicao)
                {
                    insere(fila.retirar());
                
                }
                else
                {
                    insere(valor);
                }

            }

            while (!fila.isEmpty())
            {
                insere(fila.retirar());
            }
            insere(valor);
        }

        public void reverte()
        {
            Pilha pilha = new Pilha();
            while(!isEmpty())
                pilha.push(retirar());
            while(!pilha.isEmpty())
                insere(pilha.pop());

        }

    } // fim da classe Fila 
}
