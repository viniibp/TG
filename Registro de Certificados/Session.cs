using Registro_de_Certificados.model;

namespace Registro_de_Certificados
{
    public static class Session
    {
        private static Funcionario Sessao;

        public static Funcionario GetFuncionario() => Sessao;
        public static void SetSessao(Funcionario f) => Sessao = f;
        public static void CloseSession() => Sessao = null;
    }
}
