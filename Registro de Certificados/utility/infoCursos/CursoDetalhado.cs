using System.Windows.Forms;
using Registro_de_Certificados.model;

namespace Registro_de_Certificados.utility.infoCursos
{
    public partial class CursoDetalhado : UserControl
    {
        public CursoDetalhado(Formacao f)
        {
            InitializeComponent();
            Carregar(f);
            Show();
        }

        private void Carregar(Formacao f)
        {
            lb_nomeCurso.Text = f.NomeCurso;
            lb_cargaHoraria.Text = f.CargaHoraria.ToString() + " Horas";
            lb_Inicio.Text = f.DataInicio.ToShortDateString();
            lb_Fim.Text = f.DataTermino.ToShortDateString();

            lb_peso.Text = f.Peso.ToString();
            lb_pontos.Text = f.Pontos.ToString();

            check_valido.Checked = f.Valido;
        }
    }
}
