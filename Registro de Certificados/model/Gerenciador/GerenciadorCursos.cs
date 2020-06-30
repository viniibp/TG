using System.Collections.Generic;


namespace Registro_de_Certificados.model.Gerenciador
{
    public class GerenciadorCursos
    {
        private List<Formacao> Cursos;

        public GerenciadorCursos(List<Formacao> cursos)
        {
            Cursos = cursos; // vocês são cornos
        }

        public (int, double, int) CalcularPontos_Media()
        {
            int pt = 0, mediaPeso = 0, validos = 0;
            Cursos.ForEach(f => {
                if (f.Valido)
                {
                    pt += f.Pontos;
                    mediaPeso += f.Peso;
                    validos++;
                }
            });
            return (pt, mediaPeso, validos);
        }

        public int TotalCursos() => Cursos.Count;
    }
}
