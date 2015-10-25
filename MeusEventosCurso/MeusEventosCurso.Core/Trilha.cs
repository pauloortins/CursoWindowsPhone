using System;
using System.Collections.Generic;

namespace MeusEventosCurso.Core
{
    public class Trilha
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataHora { get; set; }
        public List<Palestra> Palestras { get; set; }
    }
}