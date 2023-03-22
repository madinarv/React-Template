namespace JuanTemplate.Models
{
    public class Blog : BaseEntity
    {
        public string BlogTitle { get; set; }   
        public string BlogDescription { get; set;}
        public string Image { get; set;}
        public string ShortInfo { get; set;}
    }
}
