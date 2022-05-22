using System;
namespace ByteBank.Sistemas
{
	public class SistemaInterno
	{
		public bool Logar(IAutenticavel funcionario, string senha)
        {
			bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao Sistema!");
                return true;
            }
            Console.WriteLine("Senha Incorreta");
            return false;

        }
	}
}

