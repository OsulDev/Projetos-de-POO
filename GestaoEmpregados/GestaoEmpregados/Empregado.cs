using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEmpregados
{
    public class Empregado : Empresa
    {
        private string nomeEmp;
        private int nifEmp;
        private int numEmp;

        private const double ORDENADO_BASE = 600d;



        //------------------------CONSTRUTOR----------------
        public Empregado(string nomeEmp,int nifEmp, int numEmp)
        {
            this.nifEmp = nifEmp;
            this.numEmp = numEmp;
            this.nomeEmp = nomeEmp;
        }


        //------------------------GETTER'S E SETTER'S----------------
        public string NomeEmp
        {
            get { return nomeEmp; }
            set { nomeEmp = value; }
        }

        public int NifEmp
        {
            get { return nifEmp; }
            set { nifEmp = value; }
        }

        public int NumEmp
        {
            get { return numEmp; }
            set { numEmp = value; }
        }


        //------------------------METODOS DA CLASSE----------------
        public override string ToString()
        {
            return "Nome do empregado: " + nomeEmp + "  Nif: " + nifEmp + "  Número do empregado: " + numEmp + "  Ordenado base: " + ORDENADO_BASE;
        }

    }   
}
