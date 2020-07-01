using Registro_de_Certificados.model;

namespace Registro_de_Certificados
{
    public static class Session
    {
        private static Colaborador Sessao;

        public static Colaborador GetColaborador() => Sessao;
        public static void SetSessao(Colaborador f) => Sessao = f;
        public static void CloseSession() => Sessao = null;

    }
}
