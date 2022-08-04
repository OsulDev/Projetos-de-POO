using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEmpregados
{
    public class Engenheiro : Empregado
    {
        private double premio_salario;


        //------------------------CONSTRUTOR----------------
        public Engenheiro(string nomeEmp, int nifEmp, int numEmp, double premio_salario) : base(nomeEmp, nifEmp, numEmp)
        {
            this.premio_salario = premio_salario;
        }


        //------------------------GETTER'S E SETTER'S----------------
        public double Premio_salario
        {
            get
            {
                return premio_salario;
            }

            set
            {
                premio_salario = value;
            }
        }

        //------------------------METODOS DA CLASSE------------------
        public override string ToString()
        {
            return premio_salario.ToString();
        }
    }
}
