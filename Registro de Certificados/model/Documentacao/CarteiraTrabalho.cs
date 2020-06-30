namespace Registro_de_Certificados.model.Documentacao
{
    public class CarteiraTrabalho
    {
        public string Numero { get; set; }
        public string Serie { get; set; }

        public CarteiraTrabalho(string numero, string serie)
        {
            Numero = numero;
            Serie = serie;
        }
    }
}
