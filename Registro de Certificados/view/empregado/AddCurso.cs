using MongoDB.Bson;
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
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                FileName = "",
                Title = "Selecione uma foto",
                Filter = "JPEG|*.JPG|PNG|*.png"
            };

            openFileDialog.ShowDialog();
            if(openFileDialog.FileName != "") pic_certificado.Image = Image.FromFile(openFileDialog.FileName);
        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            Formacao curso = new Formacao
            {
                Id = ObjectId.GenerateNewId(),
                NomeCurso = text_nomecurso.Text,
                TipoCurso = combo_tipo.Items[combo_tipo.SelectedIndex].ToString(),
                AreaCurso = text_areacurso.Text,
                CargaHoraria = text_cargacurso.Text,
                DataInicio = date_inicio.Value,
                DataTermino = date_termino.Value,
                Valido = false,
                Peso = 0,
                Pontos = 0,
            };
            curso.URLCertificado = urlImagem(curso.Id.ToString());

            Colaborador f = Session.GetColaborador();
            f.AdicionarCurso(curso);

            Dispose();
        }

        private string urlImagem(string id)
        {
            string novaUrl = Environment.CurrentDirectory+"\\..\\..\\certificados\\"+id+".jpg";
            pic_certificado.Image.Save(novaUrl, pic_certificado.Image.RawFormat);
            return novaUrl;
        }

        private void Disposer(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void combo_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void text_areacurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AddCurso_Load(object sender, EventArgs e)
        {

        }
    }
}
