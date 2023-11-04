namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite()
        { }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;

            if (valorDiaria < 0)
                throw new Exception("Valor da diaria não pode ser negativo");
            ValorDiaria = valorDiaria;
        }

        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}