using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaQuestao2
{
    class Alimentacao : Pagtos
    {
        private String descricao;
        private double vlfatAliment;

        public Alimentacao(long _cpf, double _valor, int _cod,String _descricao) : base(_cpf, _valor, _cod)
        {
            descricao = _descricao;
        }

        public  override void faturar()
        {
            vlfatAliment = vlfatAliment + vlfatAliment * 0.05;
        }

        public String getDescricao()
        {
            return descricao;
        }

        public double getVlfatAliment()
        {
            return vlfatAliment;
        }

        public void setDescricao(String _descricao)
        {
            descricao = _descricao;
        }

        public void setVlfatAliment(double _vlfatAliment)
        {
            vlfatAliment = _vlfatAliment;
        }
    }
}
