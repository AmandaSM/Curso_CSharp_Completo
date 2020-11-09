﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Completo.Library.Cap.Enumeracao_Composicao.Order.Entities
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
        public override string ToString()
        {
            return $"Client: {Name} ({BirthDate}) - {Email}";
        }
    }
}
