using Registro_de_Certificados.model;
using Registro_de_Certificados.utility.infoCursos;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Registro_de_Certificados.view.empregado
{
    public partial class InfoCursos : Form
    {
        public InfoCursos()
        {
            InitializeComponent();
            Colaborador logado = Session.GetColaborador();
            Carregar(logado);
            listarCursos(logado.Formacoes);
        }

        private void Carregar(Colaborador c)
        {
            var manager = c.GerenciadorCursos();
            var (media, validos) = manager.CalcularMedia_Validos();
            var pontos = manager.Pontuacao();

            lb_cursos.Text = manager.TotalCursos().ToString();
            lb_mediaPesos.Text = media.ToString();
            lb_pontosTotais.Text = pontos.ToString();
            lb_cursosValidos.Text = validos.ToString();

            lb_ranking.Text = c.Ranking().ToString();

            var nivel = manager.Nivel(pb_nivel, pontos);

            lb_nivel.Text = "Nivel " +nivel.Level;
        }

        private void listarCursos(List<Formacao> formacoes)
        {
            formacoes.ForEach(f => PrepararCurso(f));
        }

        private void PrepararCurso(Formacao f)
        {
            CursoDetalhado cd = new CursoDetalhado(f);
            flow_cursos.Controls.Add(cd);
        }

        private void InfoCursos_Load(object sender, System.EventArgs e)
        {

        }
    }
}
