using Registro_de_Certificados.model;
using Registro_de_Certificados.utility;
using Registro_de_Certificados.view.empregado;
using System;
using System.Windows.Forms;

namespace Registro_de_Certificados.view
{
    public partial class TelaInicial : Form
    {
        public TelaInicial(Colaborador func)
        {

            InitializeComponent();
            Session.SetSessao(func);
            CarregarDados(func);
            CarregarCursos(func);

          
        }

        private void Disposer(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
            Dispose();
        }

        private void CarregarDados(Colaborador f)
        {
            
            lbl_nome.Text = f.Nome;
            lbl_cargo.Text = f.DadosTrabalhistas[0].Cargo;
            lbl_registro.Text = f.DadosTrabalhistas[0].Registro;
            lbl_cargaHorariaTotal.Text = f.CargaHorariaTotal().ToString();
            lbl_qtdCursos.Text = f.Formacoes.Count.ToString();
            lbl_tempoRegistrado.Text = f.TempoRegistrado().ToString();
            if (f.Documentos.UrlFoto != null) pb_foto.ImageLocation = f.Documentos.UrlFoto;
        }

        private void CarregarCursos(Colaborador f)
        {
            baseCursos.Controls.Clear();
            foreach (var curso in f.Formacoes)
            {
                if(curso.Valido)
                {
                    Curso c = new Curso(curso);
                    baseCursos.Controls.Add(c);
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                circularProgressBar1.Invoke((MethodInvoker)delegate
                {
                    lb_sec.Text = DateTime.Now.ToString("ss");
                    lb_dateTime.Text = DateTime.Now.ToString("hh:mm");
                    label3.Text = DateTime.Now.ToString("dddd");
                    circularProgressBar1.Value = Convert.ToInt32(lb_sec.Text);
                });
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VisualizarDadosEmp vde = new VisualizarDadosEmp();
            Hide();
            vde.ShowDialog();

            if (vde.IsDisposed)
            {
                Show();
                var func = Session.GetColaborador();
                CarregarDados(func);
                CarregarCursos(func);
            } 
       }

        private void button_logoff_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCurso vde = new AddCurso();
            Hide();
            vde.ShowDialog();

            if (vde.IsDisposed)
            {
                Show();
                var func = Session.GetColaborador();
                CarregarDados(func);
                CarregarCursos(func);
            }
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += timer_Tick;
            timer.Start();
        }
    }
}
