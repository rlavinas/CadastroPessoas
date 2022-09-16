using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncontroRemoto
{
    public class PessoaJuridica : Pessoa
    {
        public string? CNPJ {get;set;}
        public string? RazaoSocial {get;set;}

        public override void PagarImposto(float salario)
        {

        }

        public bool ValidarCNPJ(string CNPJ){
            if (CNPJ.Length != 14 || CNPJ.Substring(CNPJ.Length - 6,4) != "0001"){
                return false;
            } else {
                return true;
            }
        }
    }
}