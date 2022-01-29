namespace SAL.Interface
{
    public interface IRequisicao
    {
        string ExecutarPost(string url, string corpo);
        string ExecutarGet(string requisicao);
        
        void Dispose();
    }
}