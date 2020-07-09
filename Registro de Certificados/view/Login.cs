using Registro_de_Certificados.model;
using Registro_de_Certificados.view;
using System;
using System.Windows.Forms;

namespace Registro_de_Certificados
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //txt_username.Text = "admin";
            //txt_senha.Text = "123";
            //var funcionario = Usuario().Entrar();
            //TelaInicial homeTela = new TelaInicial(funcionario);

            //Hide();
            //homeTela.ShowDialog();

            //if (homeTela.IsDisposed)
            //{
            //    Session.CloseSession();
            //    LimparCampos();
            //    Show();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var funcionario = Usuario().Entrar();

            if(funcionario == null)
            {
                MessageBox.Show("Sem conexão");
            }
            else if (funcionario.Id.ToString().Equals("000000000000000000000000"))
            {
                lbl_aviso.Text = "Usuario ou senha invalidos!";
            }
            else
            {
                TelaInicial homeTela = new TelaInicial(funcionario);

                Hide();
                homeTela.ShowDialog();

                if (homeTela.IsDisposed)
                {
                    Session.CloseSession();
                    LimparCampos();
                    Show();
                }
            }
        }

        private void LimparCampos()
        {
            txt_username.Clear();
            txt_senha.Clear();
        }

        private Usuario Usuario() => new Usuario
        {
            Username = txt_username.Text,
            Senha = txt_senha.Text
        };

    }
}
