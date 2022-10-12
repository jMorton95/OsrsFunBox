using Newtonsoft.Json.Linq;

namespace DataController.Models
{
    public class ExchangeItem
    {
        public class Current
        {
            public string Trend { get; set; }
            public string Price { get; set; }
        }

        public class Day180
        {
            public string Trend { get; set; }
            public string Change { get; set; }
        }

        public class Day30
        {
            public string Trend { get; set; }
            public string Change { get; set; }
        }

        public class Day90
        {
            public string Trend { get; set; }
            public string Change { get; set; }
        }

        public class Item
        {
            public string Icon { get; set; }
            public string Icon_large { get; set; }
            public int Id { get; set; }
            public string Type { get; set; }
            public string TypeIcon { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public Current Current { get; set; }
            public Today Today { get; set; }
            public string Members { get; set; }
            public Day30 Day30 { get; set; }
            public Day90 Day90 { get; set; }
            public Day180 Day180 { get; set; }
        }

        public class Root
        {
            public Item Item { get; set; }
        }

        public class Today
        {
            public string Trend { get; set; }
            public string Price { get; set; }
        }

    }
}
