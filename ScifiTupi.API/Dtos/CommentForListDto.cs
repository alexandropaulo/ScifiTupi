namespace ScifiTupi.API.Dtos
{
    public class CommentForListDto
    {
          public long Id  { get; set; }
          public long Cid  { get; set; }
          public string CommentText  { get; set; }
          public string Name { get; set; }
          public string Title { get; set; }
          public string CreatedDt { get; set; }          
    }
}