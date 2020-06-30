using Registro_de_Certificados.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_Certificados.view.empregado
{
    public partial class AddCurso : Form
    {
        public AddCurso()
        {
            InitializeComponent();
        }

        private void button_confirmapic_Click(object sender, EventArgs e)
        {

        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            Formacao curso = new Formacao
            {
                NomeCurso = text_nomecurso.Text,
                TipoCurso = combo_tipo.Items[combo_tipo.SelectedIndex].ToString(),
                AreaCurso = text_areacurso.Text,
                CargaHoraria = text_cargacurso.Text,
                DataInicio = date_inicio.Value,
                DataTermino = date_termino.Value,
                Valido = true,
            };
            Colaborador f = Session.GetColaborador();
                f.AdicionarCurso(curso);
            Dispose();
        }
    }
}
