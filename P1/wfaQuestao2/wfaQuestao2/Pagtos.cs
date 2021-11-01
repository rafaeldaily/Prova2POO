using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaQuestao2
{
    class Pagtos
    {
        private long cpf;
        private double valor;
        private int cod;

        public Pagtos(long _cpf, double _valor, int _cod)
        {
            cpf = _cpf;
            valor = _valor;
            cod = _cod;
        }

        public virtual void faturar()
        {

        }

        public long getCpf()
        {
            return cpf;
        }
        public int getCod()
        {
            return cod;
        }
        public double getValor()
        {
            return valor;
        }
        public void setCpf(long _cpf)
        {
            cpf = _cpf;
        }
        public void setValor(double _valor)
        {
            valor = _valor;
        }
        public void setCod(int _cod)
        {
            cod = _cod;
        }

    }
}
