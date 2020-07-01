using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_Certificados.model
{
    public class Formacao
    {
        public string TipoCurso { get; set; }
        
        /*
         Exemplo de tipo de cursos:
            FormacaoAcademica
            CursoExtensao
            CertificacaoExterna
            TreinamentoAnual
        */

        public string AreaCurso { get; set; }
        public string NomeCurso { get;  set; }
        public string CargaHoraria{ get; set; }
        public string URLCertificado { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public bool Valido { get; set; }
        public int Pontos { get; set; }
        public int Peso { get; set; }

        public int DefinirPontos(int pontos) => Pontos = pontos * Peso;
        
    }
}
