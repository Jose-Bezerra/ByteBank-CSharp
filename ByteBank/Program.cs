using ByteBank.Funcionarios;

namespace ByteBank
{
	public class Program
	{
        public static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new();
            carlos.Nome = "Carlos";
            carlos.CPF = "023.343.678.55";
            carlos.Salario = 2000;

            Diretor roberta = new();
            roberta.Nome = "Roberta";
            roberta.CPF = "454.658.148-30";
            roberta.Salario = 5000;

            gerenciador.Registrar(carlos);
            gerenciador.Registrar(roberta);

            Console.WriteLine("Total De Bonificações: " + gerenciador.GetBonificacaoTotal());

            Console.ReadLine();
        }


	}
}

