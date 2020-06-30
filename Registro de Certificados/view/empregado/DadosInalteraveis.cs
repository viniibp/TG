using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro_de_Certificados.model;
using Registro_de_Certificados.model.Documentacao;

namespace Registro_de_Certificados.view.empregado
{
    public partial class DadosInalteraveis : Form
    {
        public DadosInalteraveis(Colaborador f)
        {
            InitializeComponent();
            LoadDados(f);
        }

        private void LoadDados(Colaborador f)
        {
            string vazio = "--------------------------------";

            DadosTrabalhistas dt = f.DadosTrabalhistas[0];

            lb_cargo.Text = dt.Cargo;
            lb_setor.Text = dt.Setor;
            lb_registro.Text = dt.Registro;
            lb_admissao.Text = dt.DataAdmissao.ToShortDateString();
            lb_jornada.Text = dt.JornadaTrabalho.ToString();
            lb_naturalidade.Text = dt.Naturalidade ?? vazio;
            lb_nacionalidade.Text = dt.Nacionalidade ?? vazio;
            lb_salario.Text = dt.Salario.ToString();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Disposer(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
}
