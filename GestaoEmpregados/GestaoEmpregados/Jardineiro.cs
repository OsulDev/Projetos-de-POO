using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEmpregados
{
    class Jardineiro:Empregado
    {
        private double subsidio_alimentar;


        //------------------------CONSTRUTOR----------------
        public Jardineiro(string nomeEmp, int nifEmp, int numEmp, double subsidio_alimentar) : base(nomeEmp, nifEmp, numEmp)
        {
            this.subsidio_alimentar = subsidio_alimentar;
        }


        //------------------------GETTER'S E SETTER'S----------------
        public double Subsidio_alimentar
        {
            get
            {
                return subsidio_alimentar;
            }

            set
            {
                subsidio_alimentar = value;
            }
        }

        //------------------------METODOS DA CLASSE------------------
        public override string ToString()
        {
            return subsidio_alimentar.ToString();
        }
    }
}
