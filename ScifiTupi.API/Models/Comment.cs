namespace ScifiTupi.API.Models
{
    public class Comment
    {
          public long Id  { get; set; }
          public long Cid  { get; set; }
          public string CommentText  { get; set; }
          public string Name { get; set; }
          public string Title { get; set; }
          public string Email { get; set; }
          public string Url { get; set; }
          public string Ip { get; set; }
          public int CreatedBy { get; set; }
          public string CreatedDt { get; set; }
          public int ModifiedBy { get; set; }
          public string ModifiedDt { get; set; }
          public string DeletedBy { get; set; }
          public string DeletedDt { get; set; }
          public int Flag { get; set; }
          public int Published { get; set; }
          public string PublishUp { get; set; }
          public string PublishDown { get; set; }
          public int ParentId { get; set; }
    }
}