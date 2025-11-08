using System;
using System.Collections.Generic;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; private set; }
        public Suite Suite { get; private set; }
        public int DiasReservados { get; private set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
            Hospedes = new List<Pessoa>();
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite == null)
                throw new InvalidOperationException("Suite não cadastrada. Cadastre a suíte antes de registrar hóspedes.");

            if (hospedes == null)
                throw new ArgumentNullException(nameof(hospedes));

            if (hospedes.Count > Suite.Capacidade)
                throw new InvalidOperationException("A suíte não comporta a quantidade de hóspedes informada.");

            Hospedes = hospedes;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes?.Count ?? 0;
        }

        public double CalcularValorDiaria()
        {
            if (Suite == null)
                throw new InvalidOperationException("Suite não cadastrada.");

            double valorTotal = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
                valorTotal *= 0.9; // desconto de 10%

            return valorTotal;
        }
    }
}