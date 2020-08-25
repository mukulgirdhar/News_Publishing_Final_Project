namespace News_Publishing_Final_Project.Models
{
    //A publication mapping of reporter and news article
    public class Publication
    {
        public int Id { get; set; }

        //Reporter id reference key
        public int ReporterId { get; set; }

        //Article id reference key
        public int NewsArticleId { get; set; }

        //Reporter reference
        public Reporter Reporter { get; set; }

        //Article reference
        public NewsArticle NewsArticle { get; set; }


    }
}
