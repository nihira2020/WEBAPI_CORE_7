namespace LearnAPI.Service
{
    public interface IRefreshHandler
    {
       Task<string> GenerateToken(string username);
    }
}
