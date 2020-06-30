using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_Certificados.model.Documentacao
{
    public class Contato
    {
        public List<string> Telefones { get; set; }
        public string Email { get; set; }

        public void AddTelefone(string tel)
        {
            if (Telefones == null) Telefones = new List<string>();
            Telefones.Add(tel);
        }
    }
}
