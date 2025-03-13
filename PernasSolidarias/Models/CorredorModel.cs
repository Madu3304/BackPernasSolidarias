namespace PernasSolidarias.Models
{
    public class CorredorModel
    {
        public int IdCorredor { get; set; }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string? Email { get; set; }
        public string? TamanhoBlusa { get; set; }
        public string? Distancia { get; set; }
        public string? UltimaCorrida { get; set; }
    }
}
