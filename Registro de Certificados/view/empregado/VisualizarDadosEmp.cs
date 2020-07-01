using System;
using System.Windows.Forms;
using Registro_de_Certificados.model;
using Registro_de_Certificados.model.Documentacao;
using Registro_de_Certificados.utility;
using Registro_de_Certificados.view.empregado;

namespace Registro_de_Certificados.view
{
    public partial class VisualizarDadosEmp : Form
    {
        private bool isEditing;

        public VisualizarDadosEmp()
        {
            InitializeComponent();
            LoadDados();
            isEditing = false;
        }

        private void VisualizarDadosEmp_Load(object sender, EventArgs e)
        {
        }

        private void LoadDados()
        {
            Colaborador f = Session.GetColaborador();
            if (f.Contatos == null) f.Contatos = new Contato();

            lb_nome.Text = f.Nome;
            lb_email.Text = f.Contatos.Email;
            lb_cpf.Text = f.Documentos.CPF;
            lb_rg.Text = f.Documentos.RG;
            lb_titulo.Text = f.Documentos.TituloEleitoral;
            lb_reservista.Text = f.Documentos.NumeroReservista;
            LoadTelefones();
        }

        private void edit_save_Click(object sender, EventArgs e)
        {
            isEditing = !isEditing;

            edit_save.Text = isEditing ? "Salvar" : "Editar";


            if (!isEditing)
            {
                if (MessageBox.Show("Deseja salvar as aterações?", "Confirmação", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Salvar();
                    LoadDados();
                    SetTexts();
                    LoadTelefones();
                }
            }
            else
            {
                SetTexts();
            }

            foreach (Telefone modelo in flow_telefone.Controls)
            {
                modelo.isEditing(isEditing);
            }
        }

        private void Salvar()
        {
            Colaborador f = Session.GetColaborador();

            f.Nome = text_nome.Text;
            f.Contatos.Email = text_email.Text;
            f.Documentos.CPF = text_cpf.Text;
            f.Documentos.RG = text_rg.Text;
            f.Documentos.TituloEleitoral = text_titulo.Text;
            f.Documentos.NumeroReservista = text_reservista.Text;

            f.Contatos.Telefones.Clear();
            foreach(Telefone tel in flow_telefone.Controls)
            {
                string numero = tel.GetTelefone();
                Console.WriteLine(tel.CanRemove() + " telefone -> "+ numero);
                if (tel.CanRemove()) f.Contatos.Telefones.Remove(numero);
                if (!f.Contatos.Telefones.Contains(numero) && tel.CanRemove() == false) f.Contatos.AddTelefone(numero);
            }
            f.Atualizar();

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void LoadTelefones()
        {
            flow_telefone.Controls.Clear();

            Colaborador f = Session.GetColaborador();

            if(f.Contatos.Telefones != null)
            {
                foreach (string tel in f.Contatos.Telefones)
                {
                    Telefone modelo = new Telefone(tel);
                    flow_telefone.Controls.Add(modelo);
                }
            }
        }
        //---------------------------------------------------------------------
        private void SetTexts()
        {
            SetModeTexts(text_nome, lb_nome.Text);
            SetModeTexts(text_email, lb_email.Text);
            SetModeTexts(text_cpf, lb_cpf.Text);
            SetModeTexts(text_rg, lb_rg.Text);
            SetModeTexts(text_titulo, lb_titulo.Text);
            SetModeTexts(text_reservista, lb_reservista.Text);

            text_numero.Visible = isEditing;
            button_add.Visible = isEditing;
            text_numero.Enabled = isEditing;
            button_add.Enabled = isEditing;
        }

        private void SetModeTexts(TextBox txt, string texto){
            txt.Visible = isEditing;
            txt.Enabled = isEditing;
            txt.Text = texto;
        }

        private void Disposer(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Colaborador f = Session.GetColaborador();


            f.Contatos.AddTelefone(text_numero.Text);
            LoadTelefones();

        }

        private void button_inalteravel_Click(object sender, EventArgs e)
        {
            Colaborador f = Session.GetColaborador();
            DadosInalteraveis di = new DadosInalteraveis(f);
            Hide();
            di.ShowDialog();
            if (di.IsDisposed) Show();
        }
    }
}
