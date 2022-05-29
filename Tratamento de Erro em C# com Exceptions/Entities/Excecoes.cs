namespace Tratamento_de_Erro_em_C#_com_Exceptions.Entities
{
    public class Excecoes : Exception
    {
        public Excecoes()
        {

        }

        public Excecoes(string? message) : base(message)
        {

        }

        public Excecoes(string? message, Exception? innerException) : base(message, innerException)
        {

        }

        protected Excecoes(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }

        public string? MinhaPropriedade { get; set; }
    }
}