using System;
using System.Windows.Forms;
using Registro_de_Certificados.DAO.modelDAO;
using Registro_de_Certificados.model;
using Registro_de_Certificados.utility;

namespace Registro_de_Certificados
{
    static class Program
    {

        [STAThread]
        static void Main()
        {

            //var carteiratrabalho = new model.Documentacao.CarteiraTrabalho("4002", "8922");

            //var documentos = new model.Documentacao.Documentos
            //{
            //    CPF = "469.540.428-11",
            //    RG = "52.759.098-8",
            //    CarteiraTrabalho = carteiratrabalho
            //};

            //var dt = new model.Documentacao.DadosTrabalhistas
            //{
            //    Registro = "00000-00",
            //    Cargo = "gerente",
            //    Setor = "rh",
            //    DataAdmissao = DateTime.Today,
            //    JornadaTrabalho = 8,
            //    Salario = 1_045.00f,
            //};

            //var dp = new model.Documentacao.DadosPessoais
            //{
            //    DataNascimento = new DateTime(2000, 12, 13),
            //    EstadoCivil = "online",
            //    Genero = "batman",
            //    Sexo = "masculino",
            //    Idade = 19,
            //    QtdFilhos = 0
            //};

            //var police = new Funcionario
            //{
            //    Nome = "vinicius batista",
            //    Username = "admin",
            //    Senha = new MD5Hash().GetMd5Hash("123"),
            //    AtivoContratado = true,
            //    Documentos = documentos,
            //    DadosPessoais = dp,

            //};
            //police.Salvar();
            //police.AtualizarDadosTrabalhistas(dt);

            //var policiais = new FuncionarioDAO().AllFuncionarios();

            //foreach (var po in policiais)
            //{
            //    Console.WriteLine(po.Nome);
            //    po.Atualizar();
            //    po.Deletar();
            //}


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

        }
    }
}
