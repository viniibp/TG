using System.Drawing;
using System.Windows.Forms;
using Registro_de_Certificados.model;
using System;

namespace Registro_de_Certificados.utility
{
    public partial class Telefone : UserControl
    {
        private string telefone;

        public Telefone(string tel)
        {
            InitializeComponent();
            telefone = tel;
            lb_numero.Text = tel;
            Show();
        }

        public string GetTelefone() => telefone;

        public void isEditing(bool edit)
        {
            button_remove.Visible = edit;
        }

        public bool CanRemove() => !lb_numero.Enabled;

        private void button_remove_Click(object sender, System.EventArgs e)
        {
            lb_numero.Enabled = !lb_numero.Enabled;
            Console.WriteLine(lb_numero.Enabled);
            if (!lb_numero.Enabled) BackColor = Color.Red;
            else BackColor = Color.White;
        }
    }
}
