using System;
using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
	public class Diretor : FuncionarioAutenticavel
	{
        public Diretor(string cpf) : base(cpf, 5000) 
        {
            Console.WriteLine("Construtor da classe Diretor");
        }

        public override void AumentarSalario()
        {
            //Salario = Salario + (Salario * 0.15);
            //Salario = Salario * 1.15;
            Salario *= 1.15;

        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}

