using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Completo.Library.Cap.Linq.Entitite
{
   public  class FuncionarioD
    {
        public double Salary { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public FuncionarioD(double salary, string name, string email)
        {
            Salary = salary;
            Name = name;
            Email = email;
        }
        /*public override string ToString()
        {
            return $"Name:{Name},Salary{Salary}, Email{Email} ";
        }*/
    }
}
