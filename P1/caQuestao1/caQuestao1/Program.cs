using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Data d1 = new Data(30,3,2022);
            Data d2 = new Data(1, 2, 2021);
            Console.WriteLine(d1.compara(d2));
            Console.WriteLine(d2.getDia());
            Console.Read();
        }
    }
}
