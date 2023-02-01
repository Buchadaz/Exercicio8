using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    public class Candidato
    {
        public string Nome;
        public double x1, x2, x3;

        public double NotaFinal()
        {
            return x1 + x2 + x3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60)
            {
                return true;
            }
            else return false;
        }
        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else { return 60.0 - NotaFinal(); }
        }
    }


}