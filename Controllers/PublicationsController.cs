using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using News_Publishing_Final_Project.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace News_Publishing_Final_Project.Controllers
{
    //Publication controller
    
    public class PublicationsController : Controller
    {
        private readonly News_PublishingDataContext _context;
        SignInManager<IdentityUser> SignInManager;

        public PublicationsController(News_PublishingDataContext context,
             SignInManager<IdentityUser> SignInManager
            )
        {
            this.SignInManager = SignInManager;
            _context = context;
        }

        // GET: Publications
        //Shows all news article with  reporter and published date
        public async Task<IActionResult> Index()
        {
            if(SignInManager.IsSignedIn(User) && User.IsInRole("reporter"))
            {
                var reporterArticles = _context.Publication.Include(p => p.NewsArticle).Include(p => p.Reporter).
                    Where(p=> p.Reporter.EmailAddress.Equals(User.Identity.Name));
                return View(await reporterArticles.ToListAsync());


            }
            var news_PublishingDataContext = _context.Publication.Include(p => p.NewsArticle).Include(p => p.Reporter);
            return View(await news_PublishingDataContext.ToListAsync());
        }

        
       
       
    }
}
