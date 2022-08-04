using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEmpregados
{
    class Administrador : Empregado
    {
        private int numPromo;

        private const double VENCIMENTO_PROMOCAO = 100d;


        //------------------------CONSTRUTOR----------------
        public Administrador(string nomeEmp, int nifEmp, int numEmp, int numPromo) : base(nomeEmp, nifEmp, numEmp)
        {
            this.numPromo = numPromo;
        }


        //------------------------GETTER'S E SETTER'S----------------
        public int NumPromo
        {
            get
            {
                return numPromo;
            }

            set
            {
                numPromo = value;
            }
        }



        //------------------------METODOS DA CLASSE------------------
        public override string ToString()
        {
            return "Número de promoções: " + numPromo + " Vencimento da promoção: " + VENCIMENTO_PROMOCAO;
        }
    }
}
