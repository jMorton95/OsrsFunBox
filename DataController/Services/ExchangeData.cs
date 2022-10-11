namespace DataController.Services
{
    public class ExchangeData : IExchangeData
    {
        private readonly HttpClient _httpClient;
        
        public ExchangeData()
        {
            _httpClient = new HttpClient();
        }
        public async Task<String> GetExchangeRecord(int id)
        {
            /*var getId = 3000;*/

            var res = await _httpClient.GetAsync("https://secure.runescape.com/m=itemdb_oldschool/api/catalogue/detail.json?item=" + id);
            
            var data = await res.Content.ReadAsStringAsync();

            return data;
        }
    }
}
