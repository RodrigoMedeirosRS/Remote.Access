using SAL;
using SAL.Interface;

namespace Remote.Access
{
    public class Program
    {
        private static IRequisicao Request { get; set; }
        static Program()
        {
            Request = new Requisicao();
        }
        public static void Main(string[] args)
        {
            try
            {
                var argumento = args[0].Split("|");
                var retorno = Request.ExecutarPost(argumento[0], argumento[1]);
                Console.WriteLine(retorno);
                Request.Dispose();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
