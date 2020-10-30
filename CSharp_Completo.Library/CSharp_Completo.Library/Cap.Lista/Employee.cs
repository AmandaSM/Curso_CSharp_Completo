using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CSharp_Completo.Library.Cap.Lista
{
    public class Employee
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Employee(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }
        public double Aumento(double porcentagem)
        {
            return Salario += Salario * porcentagem/100.0;
        }
        public override string ToString()
        {
            return $"{Id }, {Nome}, {Salario.ToString("F2", CultureInfo.InvariantCulture)}";
        }
        
    }

}
