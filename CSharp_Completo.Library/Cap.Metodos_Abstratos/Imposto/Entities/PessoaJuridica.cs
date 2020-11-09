using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Completo.Library.Cap.Metodos_Abstratos.Imposto
{
     class PessoaJuridica : TaxPayer
    {
        public int NumeroFuncionarios { get; set; }

        public PessoaJuridica(int numeroFuncionarios, string name, double anualIncome) : base(name, anualIncome)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double Imposto()
        {
            return (NumeroFuncionarios >= 10) ? (AnualIncome * 0.14) : ( AnualIncome * 0.16);
        }

    }
}




