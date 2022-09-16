﻿using EncontroRemoto;

namespace EncontroRemoto
{
    class Program
    {
        static void Main(string[] args)
        {
            Endereco endPF = new Endereco();
            endPF.Logradouro  = "Rua Silveira Martins";
            endPF.Numero      = 24;
            endPF.Complemento = "Apto 113";
            endPF.EnderecoComercial = false;

            PessoaFisica novaPF = new PessoaFisica();
            novaPF.CPF            = "12345678955";
            novaPF.DataNascimento = new DateTime(1979, 11, 05);
            novaPF.Nome           = "Rafael Ramos";
            novaPF.Endereco       = endPF;
            novaPF.Email          = "rlavinas@gmail.com";

            Endereco endPJ = new Endereco();
            endPF.Logradouro  = "Rua Silveira Martins";
            endPF.Numero      = 24;
            endPF.Complemento = "Apto 335";
            endPF.EnderecoComercial = false;

            PessoaJuridica novaPJ = new PessoaJuridica();
            novaPJ.CNPJ        = "01001001000123";
            novaPJ.RazaoSocial = "RRL";
            novaPJ.Endereco    = endPJ;

            bool CNPJValido = novaPJ.ValidarCNPJ(novaPJ.CNPJ);

            if (CNPJValido == true){
                Console.WriteLine("CNPJ válido");
            } else {
                Console.WriteLine("CNPJ inválido");
            }

            Console.WriteLine($"Rua: {novaPF.Endereco.Logradouro}, {novaPF.Endereco.Numero}");
            Console.WriteLine($"Data Nascimento : {novaPF.DataNascimento}");

            bool idadeValida = novaPF.ValidarDataNascimento(novaPF.DataNascimento);

            if (idadeValida == true) {
                System.Console.WriteLine($"Cadastro Aprovado");
            } else {
                System.Console.WriteLine($"Cadastro Reprovado");
            }
        }
    }
}