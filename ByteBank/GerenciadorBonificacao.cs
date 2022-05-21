﻿using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
	public class GerenciadorBonificacao
	{
		private double _totalBonificacao;

		public void Registrar(Funcionario funcionario)
        {
			_totalBonificacao += funcionario.GetBonificacao();
        }

		public void Registrar(Diretor diretor)
        {
			_totalBonificacao += diretor.GetBonificacao();
        }

		public double GetBonificacaoTotal()
        {
			return _totalBonificacao;
        }
	}
}
