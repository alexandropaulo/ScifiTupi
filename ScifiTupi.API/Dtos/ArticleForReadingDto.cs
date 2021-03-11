using System;
using System.Collections.Generic;

namespace ScifiTupi.API.Dtos
{
    public class ArticleForReadingDto
    {
        public int Id  { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public string IntroText { get; set; }
        public string FullText { get; set; }
        public int State { get; set; }
        public int Catid { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedBy { get; set; }
        public string Category { get; set; }
        public string ImageIcon { get; set; }
        public string Metadata { get; set; }
        public string Metakey { get; set; }
        public string MetaDesc { get; set; }
        public int Access { get; set; }
        public int Hits { get; set; }
        public ICollection<CommentForReadingDto> Comments { get; set; }
    }
}