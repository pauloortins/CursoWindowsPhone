namespace MeusEventosCurso.Core
{
    public class Palestra
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string DataHora { get; set; }
        public Palestrante Palestrante { get; set; }
    }
}