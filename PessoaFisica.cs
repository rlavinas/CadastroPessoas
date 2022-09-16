using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncontroRemoto
{
    public class PessoaFisica : Pessoa
    {
        public string? CPF {get;set;}

        public DateTime DataNascimento {get;set;}

        public override void PagarImposto(float salario)
        {

        }

        public bool ValidarDataNascimento(DateTime DataNasc){
            
            DateTime DataAtual = DateTime.Today;

            double Anos = (DataAtual - DataNasc).TotalDays / 365;

            if (Anos >= 18) {
                return true;
            } else {
                return false;
            }
        }
    }
}