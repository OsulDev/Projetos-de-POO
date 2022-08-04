using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEmpregados
{
    public class Gestor : Empregado
    {
        private double suplemento_salario;


        //------------------------CONSTRUTOR----------------
        public Gestor(string nomeEmp, int nifEmp, int numEmp, double suplemento_salario) : base(nomeEmp, nifEmp, numEmp)
        {
            this.suplemento_salario = suplemento_salario;
        }


        //------------------------GETTER'S E SETTER'S----------------
        public double Suplemento_salario
        {
            get
            {
                return suplemento_salario;
            }

            set
            {
                suplemento_salario = value;
            }
        }



        //------------------------METODOS DA CLASSE------------------
        public override string ToString()
        {
            return "Suplemento do salário: " + suplemento_salario;
        }
    }
    
}
