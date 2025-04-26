namespace EchoMind.Exception.ExceptionsBase
{
    public abstract class EchoMindBaseException : System.Exception
    {

        protected EchoMindBaseException(string message) : base(message)
        {
        }
    }
}
