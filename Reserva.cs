using System;
using System.Collections.Generic;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public Suite Suite { get; set; }
        public List<Pessoa> Hospedes { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            Hospedes = new List<Pessoa>();
            DiasReservados = diasReservados;
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            Hospedes.AddRange(hospedes);
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public double CalcularValorDiaria()
        {
            double valorTotal = Suite.ValorDiaria * DiasReservados;

            // Aplica desconto de 10% para reservas maiores que 10 dias
            if (DiasReservados > 10)
            {
                valorTotal *= 0.9;
            }

            return valorTotal;
        }
    }
}
