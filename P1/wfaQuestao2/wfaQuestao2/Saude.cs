using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaQuestao2
{
    class Saude : Pagtos
    {
        private String estabelecimento;
        private double vlfatSaude;

        public Saude(long _cpf, double _valor, int _cod, String _estabelecimento) : base(_cpf, _valor, _cod)
        {
            estabelecimento = _estabelecimento;
        }

        public override void faturar()
        {
            vlfatSaude = vlfatSaude + vlfatSaude * 0.12;
        }

        public String getEstabelecimento()
        {
            return estabelecimento;
        }

        public double getVlfatSaude()
        {
            return vlfatSaude;
        }

        public void setEstabelecimento(String _estabelecimento)
        {
            estabelecimento = _estabelecimento;
        }

        public void setVlfatSaude(double _vlfatSaude)
        {
            vlfatSaude = _vlfatSaude;
        } 
    }
}
