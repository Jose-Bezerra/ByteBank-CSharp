using ByteBank.Funcionarios;

namespace ByteBank.Sistemas
{
    public abstract class Autenticavel : Funcionario
    {
        public string Senha { get; set; }

        protected Autenticavel(string cpf, double salario) : base(cpf, salario)
        {

        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}