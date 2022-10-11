using DataController.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

namespace DataController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OsrsController : Controller
    {
        ExchangeData GE = new ExchangeData();
        
        [HttpGet]
        public async Task<string> Get()
        {
            /*string baseUrl = "https://secure.runescape.com/m=itemdb_oldschool/api/catalogue/detail.json?item=3000";
            var dataString = "";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                    {
                        using (HttpContent content = res.Content)
                        {
                            Console.WriteLine(content.ReadAsStream());

                            var data = await content.ReadAsStringAsync();

                            if (data != null)
                            {
                                dataString = data;
                                //Console.WriteLine(dataString);
                                var token1 = JObject.Parse(dataString);
                                //Console.WriteLine(token1);
                            }
                            else
                            {
                                Console.WriteLine("No data");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            var token = JObject.Parse(dataString);*/

            var token = await GE.GetExchangeRecord();
            return token;
        }
    }
}
