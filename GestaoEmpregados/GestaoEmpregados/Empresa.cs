using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestaoEmpregados
{
    public class Empresa
    {
        //-------ATRIBUTOS------
        private const int MAX_EMPS = 100;

        private Empregado[] tabelaEmps; 
        private int numEmps;


        //--------------Construtor da classe Empresa---------------
        public Empresa()
        {
            this.tabelaEmps = new Empregado[MAX_EMPS];
            this.numEmps = 0;
        }


        //------------getter's e setter's------------
        public Empregado[] TabelaEmps
        {
            get { return tabelaEmps; }
            set { tabelaEmps = value; }
        }

        public int NumEmps
        {
            get { return numEmps; }
            set { numEmps = value; }
        }


        //-----------------MÉTODOS--------------
        public void AdicionarEmp(Empregado e)
        {
            if (numEmps < MAX_EMPS) //se o numero de empregados for menor que o máximo de empregados permitidos, então
            {
                tabelaEmps[numEmps++] = e;   //adiciona o empregado
            }
        }


        public void RemoveEmp(Empregado e)
        {
            for (int i = 0; i < numEmps; i++)
            {
                if (tabelaEmps[i] == e)
                {
                    for (int j = i; j < numEmps; j++)
                    {
                        tabelaEmps[j] = tabelaEmps[j++];
                    }
                    numEmps--;
                }
            }
        }
    }
}