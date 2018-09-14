using System;

namespace Votacao.Model
{
    public class Voto
    {
        public DateTime DataHora { get; set; }
        public string Sexo { get; set; }
        public string Sala { get; set; }
        public Candidato Candidato { get; set; }
    }
}
