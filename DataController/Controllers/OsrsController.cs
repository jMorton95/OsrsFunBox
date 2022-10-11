using DataController.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static DataController.Models.ExchangeItem;

namespace DataController.Controllers
{
    [Route("api/[controller]/id")]
    [ApiController]
    public class OsrsController : Controller
    {
        ExchangeData GE = new ExchangeData();
        
        [HttpGet]
        public async Task<String> GetName(int Id)
        {
            var record = await GE.GetExchangeRecord(Id);
            
            Root? parsedRecord = JsonConvert.DeserializeObject<Root>(record);

            Console.WriteLine(parsedRecord.item.name);

            var itemName = parsedRecord.item.name;
            
            return itemName;
        }
    }
}
