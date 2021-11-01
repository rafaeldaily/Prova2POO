using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaQuestao2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSaude_MouseClick(object sender, MouseEventArgs e)
        {
            Relatorio.addPagamentos(new Saude(Convert.ToInt64(tbSaude1), Convert.ToDouble(tbSaude1), Convert.ToInt32(tbSaude3),Convert.ToString(tbSaude4)));
        }

        private void btAlimentacao_MouseClick(object sender, MouseEventArgs e)
        {
            Relatorio.addPagamentos(new Saude(Convert.ToInt64(tbAlimentacao1), Convert.ToDouble(tbAlimentacao2), Convert.ToInt32(tbAlimentacao3), Convert.ToString(tbAlimentacao4)));
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btSaude_Click(object sender, EventArgs e)
        {

        }
    }
}
