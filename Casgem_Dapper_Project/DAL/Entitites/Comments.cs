namespace Casgem_Dapper_Project.DAL.Entitites
{
    public class Comments
    {
        public int CommentID { get; set; }
        public string CommentContent { get; set; }
        public string CommentAuthor { get; set; }
        public bool CommentStatus { get; set; }
        public DateTime CommentDate { get; set; }
        public int CommentHeading { get; set; }
    }
}
