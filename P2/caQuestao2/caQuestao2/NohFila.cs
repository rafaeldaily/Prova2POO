using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao2
{
    class Noh
    {
        //atributos
        private int data;
        private Noh anterior;

        //Construtores

        public Noh()
        {
            data = 0;
            anterior = null;
        }

        public Noh(int valor)
        {
            data = valor;
            anterior = null;
        }

        public Noh(int valor, Noh prior)
        {
            data = valor;
            anterior = prior;
        }

        //getters and setters

        public int getData()
        {
            return data;
        }

        public Noh getAnterior()
        {
            return anterior;
        }

        public void setData(int valor)
        {
            data = valor;
        }

        public void setAnterior(Noh prior)
        {
            anterior = prior;
        }
    }
}
