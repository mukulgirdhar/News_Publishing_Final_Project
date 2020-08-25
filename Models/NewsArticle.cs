using System;

namespace News_Publishing_Final_Project.Models
{
    //Represents a news article with a headline content and publication date
    public class NewsArticle
    {
        public int Id { get; set; }

        public string Headline { get; set; }


        public string Content { get; set; }

        public DateTime PublishedTime { get; set; }


    }
}
