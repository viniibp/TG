using Registro_de_Certificados.model;
using System.Windows.Forms;

namespace Registro_de_Certificados.view.empregado
{
    public partial class infoCursos : Form
    {
        public infoCursos()
        {
            InitializeComponent();
            Carregar(Session.GetColaborador()); //teste de merge
        }

        public void Carregar(Colaborador c)
        {
            var manager = c.GerenciadorCursos();
            var (pontos, media, validos) = manager.CalcularPontos_Media();

            lb_cursos.Text = manager.TotalCursos().ToString();
            lb_mediaPesos.Text = media.ToString();
            lb_pontosTotais.Text = pontos.ToString();
            lb_cursosValidos.Text = validos.ToString();
        }
    }
}
