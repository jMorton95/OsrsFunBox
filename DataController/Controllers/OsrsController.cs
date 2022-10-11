using DataController.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static DataController.Models.ExchangeItem;

namespace DataController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OsrsController : Controller
    {
        ExchangeData GE = new ExchangeData();
        
        [HttpGet]
        public async Task<Root> Get()
        {
            var itemLookup = await GE.GetExchangeRecord();
            
            Root? item = JsonConvert.DeserializeObject<Root>(itemLookup);
                
            
            return item;
        }
    }
}
