namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public double ValorDiaria { get; set; }

        public Suite(string tipoSuite, int capacidade, double valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
    }
}