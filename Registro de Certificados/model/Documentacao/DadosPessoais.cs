using System;

namespace Registro_de_Certificados.model.Documentacao
{
    public class DadosPessoais
    {
        public sbyte Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public sbyte QtdFilhos { get; set; }
        public string EstadoCivil { get; set; }
        public string Sexo { get; set; }
        public string Genero { get; set; }
    }
}
