namespace DataController.Services
{
    public interface IExchangeData
    {
        
        Task<string> GetExchangeRecord(int id);
    }
}
