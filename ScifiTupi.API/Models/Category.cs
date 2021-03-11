using System.Collections.Generic;

namespace ScifiTupi.API.Models
{
    public class Category
    {
        public int Id { get; set; }
        public int Parent_id { get; set; }
        public string Path { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Note { get; set; }
        public string Description { get; set; }
        public int Published { get; set; }
        public int hits { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}