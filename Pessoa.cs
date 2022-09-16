using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncontroRemoto
{
    public abstract class Pessoa
    {
        public string? Nome {get;set;}
        public string? Email {get;set;}
        public Endereco? Endereco {get;set;}

        public abstract void PagarImposto(float salario);

        public bool GravarRegistro() {
            return true;
        }
    }
}