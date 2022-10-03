namespace Consulta_VIA_Cep.Comum
{
    public class RetornoPersonalizado
    {
        public bool Sucesso { get; private set; }
        public string Mensagem { get; private set; }
        public object Dados { get; private set; }

        public RetornoPersonalizado(bool sucesso, string mensagem)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
        }

        public RetornoPersonalizado(bool sucesso, string mensagem, object dados)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
            Dados = dados;
        }
    }
}