using Microsoft.EntityFrameworkCore;

namespace News_Publishing_Final_Project.Models
{
    //Connects the database with models 
    public class News_PublishingDataContext : DbContext
    {
        public News_PublishingDataContext (DbContextOptions<News_PublishingDataContext> options)
            : base(options)
        {
        }

        public DbSet<News_Publishing_Final_Project.Models.NewsArticle> NewsArticle { get; set; }

        public DbSet<News_Publishing_Final_Project.Models.Publication> Publication { get; set; }

        public DbSet<News_Publishing_Final_Project.Models.Reporter> Reporter { get; set; }
    }
}
