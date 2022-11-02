
using EncontroRemoto;
using System.Threading;

namespace EncontroRemoto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(@$"
============================================
|    Bem vindo ao sistema de cadastro      |
|    de pessoa física e pessoa jurídica    |
============================================
");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            BarraCarregamento("Iniciando");
            Console.ResetColor();

            string cOpcao = "1";
            
            while (cOpcao != "0")
            {
                Console.WriteLine(@$"
========================================
|    Escolha uma das opções abaixo     |
|       1 - Pessoa Física              |
|       2 - Pessoa Jurísica            |
|       0 - Sair                       |
========================================
");  
                Console.ResetColor();
                cOpcao = Console.ReadLine();
                switch (cOpcao)
                {
                    case "1":
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
                        novaPF.Salario        = 7000F;

                        Console.WriteLine($"Rua: {novaPF.Endereco.Logradouro}, {novaPF.Endereco.Numero}");
                        Console.WriteLine($"Data Nascimento : {novaPF.DataNascimento}");
                        Console.WriteLine($"Imposto PF: {novaPF.PagarImposto(novaPF.Salario)}");

                        bool idadeValida = novaPF.ValidarDataNascimento(novaPF.DataNascimento);

                        if (idadeValida == true) {
                            System.Console.WriteLine($"Cadastro Aprovado");
                        } else {
                            System.Console.WriteLine($"Cadastro Reprovado");
                        }

                        Thread.Sleep(3000);

                        break;
                    case "2":
                        Endereco endPJ = new Endereco();
                        endPJ.Logradouro  = "Rua Silveira Martins";
                        endPJ.Numero      = 24;
                        endPJ.Complemento = "Apto 335";
                        endPJ.EnderecoComercial = false;

                        PessoaJuridica novaPJ = new PessoaJuridica();
                        novaPJ.CNPJ        = "01001001000123";
                        novaPJ.RazaoSocial = "RRL";
                        novaPJ.Endereco    = endPJ;
                        novaPJ.Salario     = 20000F;

                        bool CNPJValido = novaPJ.ValidarCNPJ(novaPJ.CNPJ);
                        
                        Console.WriteLine(novaPJ.PagarImposto(novaPJ.Salario));
                        Console.WriteLine($"Imposto PJ: {novaPJ.PagarImposto(novaPJ.Salario)}");

                        if (CNPJValido == true){
                            Console.WriteLine("CNPJ válido");
                        } else {
                            Console.WriteLine("CNPJ inválido");
                        }

                        Thread.Sleep(3000);

                        break;
                    case "0":
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Obrigado por utilizar nosso sistema");                        
                        Console.WriteLine($"");
                        BarraCarregamento("Finalizado");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção inválida. Escolha uma opção válida.");
                        Thread.Sleep(2000);
                        break;
                }
                Console.Clear();
            }

            Console.ResetColor();
        }
        static void BarraCarregamento(string cTexto){
            Console.Write($"{cTexto}");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(500);
                Console.Write($".");     
            } 
            Console.WriteLine($""); 
        }
    }
}
