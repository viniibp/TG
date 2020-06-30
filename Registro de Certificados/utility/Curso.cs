using Registro_de_Certificados.model;
using System.Windows.Forms;

namespace Registro_de_Certificados.utility
{
    public partial class Curso : UserControl
    {

        public Curso(Formacao f)
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
        }

    }
}
