using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Completo.Library.Cap.Enumeracao_Composicao.Entities
{
    public class Department
    {
        public string Name { get; set; }
        public Department()
        {

        }
        public Department(string name)
        {
            Name = name;
        }
    }
}
