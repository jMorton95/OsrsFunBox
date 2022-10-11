namespace DataController.Services
{
    public class ExchangeData : IExchangeData
    {
        private readonly HttpClient _httpClient;
        
        public ExchangeData()
        {
            _httpClient = new HttpClient();
        }
        public async Task<string> GetExchangeRecord()
        {
            var getId = 3000;

            var res = await _httpClient.GetAsync("https://secure.runescape.com/m=itemdb_oldschool/api/catalogue/detail.json?item=" + getId);
            Console.WriteLine(res.ToString());
            return "hi";
        }
    }
}
