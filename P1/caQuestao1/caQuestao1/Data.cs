using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao1
{
    class Data
    {
        private int dia;
        private int mes;
        private int ano;

        public Data(int _dia, int _mes, int _ano)
        {
            dia = _dia;
            mes = _mes;
            ano = _ano;
        }

        public int compara(Data data2)
        {
            if(ano >=data2.getAno())
            {
                if(ano == data2.getAno())
                {
                    if(mes >= data2.getMes())
                    {
                        if (mes == data2.getMes())
                        {
                            if (dia>=data2.getDia())
                            {
                                if (dia == data2.getDia())
                                {
                                    return 0;
                                }
                                else
                                {
                                    return 1;
                                }
                            }
                            else
                            {
                                return -1;
                            }
                        }
                        else
                        {
                            return 1;
                        }
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return -1;
            }
        }

        public int getDia()
        {
            return dia;
        }

        public int getMes()
        {
            return mes;
        }

        public String getMesExtenso()
        {
            String[] nomes_meses = {"janeiro", "fevereiro", "março", "abril", "maio", "junho", "agosto", "outubro", "novembro", "dezembro" };
            return nomes_meses[mes-1];

        }

        public Boolean isBissexto()
        {
            if(ano%400==0 || (ano%4==0 && ano%100!=0)){
                return true;
            }
            return false;
        }

        public Data clone()
        {
            return new Data(dia, mes, ano);
        }

        public int getAno()
        {
            return ano;
        }
    }
}
