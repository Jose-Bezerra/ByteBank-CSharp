using System;

namespace ByteBank.Funcionarios
{
	public abstract class Funcionario
	{
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; set; }

        public Funcionario(string cpf, double salario)
        {
            Console.WriteLine("Contrutor da classe Funcionário");
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();


        public abstract double GetBonificacao();
        
    }
}

