using System;

namespace ScifiTupi.API.Dtos
{
    public class ArticleForContentDto
    {
        public int Id  { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public string IntroText { get; set; }
        public string Category { get; set; }
        public DateTime CreatedDt { get; set; }
        public string CreatedByAlias { get; set; }
        public string ImageIcon { get; set; }
        public int Hits { get; set; }
    }
}