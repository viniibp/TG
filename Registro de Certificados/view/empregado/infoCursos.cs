using Registro_de_Certificados.model;
using System.Windows.Forms;

namespace Registro_de_Certificados.view.empregado
{
    public partial class InfoCursos : Form
    {
        public InfoCursos()
        {
            InitializeComponent();
            Carregar(Session.GetColaborador()); 
        }

        public void Carregar(Colaborador c)
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
    }
}
