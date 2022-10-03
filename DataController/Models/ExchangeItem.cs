using Newtonsoft.Json.Linq;

namespace DataController.Models
{
    public class ExchangeItem
    {
        public JToken Item;

        public ExchangeItem(string data)
        {
            Item = JObject.Parse(data);
        }
    }
}
