using System.Collections.Generic;

namespace CodeBaseWeb.Models
{
    public class Item : Auditable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }

        public string Image_url { get; set; }

        public IEnumerable<Tag> Tags { get; set; }
    }
}