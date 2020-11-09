using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Completo.Library.Cap.Tratamento_Execoes.Entitites.Exceptions
{
    class DomainException: ApplicationException
    {
        public DomainException(string message):base(message)
        {

        }
    }
}
