using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaQuestao2
{
    class Relatorio
    {
        private static List<Pagtos> pagamentos = new List<Pagtos>();

        public List<Pagtos> getPagamentos()
        {
            return pagamentos;
        }

        public static void addPagamentos(Pagtos pg)
        {
            pagamentos.Add(pg);
        }
    }
}
