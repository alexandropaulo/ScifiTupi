using System.Collections.Generic;

namespace ScifiTupi.API.Models
{
    public class Article
    {
        public int Id  { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public string IntroText { get; set; }
        public string FullText { get; set; }
        public int State { get; set; }
        public int Catid { get; set; }
        public string CreatedDt { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedByAlias { get; set; }
        public string ModifiedDt { get; set; }
        public int ModifiedBy { get; set; }
        public int CheckedOut { get; set; }
        public string CheckedOutTime { get; set; }
        public string PublishUpDt { get; set; }
        public string PublishDownDt { get; set; }
        public string ImageIcon { get; set; }
        public string Urls { get; set; }
        public int Version { get; set; }
        public int Ordering { get; set; }
        public string Metadata { get; set; }
        public string Metakey { get; set; }
        public string MetaDesc { get; set; }
        public int Access { get; set; }
        public int Hits { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}