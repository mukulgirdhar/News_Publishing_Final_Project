using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using News_Publishing_Final_Project.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace News_Publishing_Final_Project.Controllers
{
    
    //News article controller
    public class NewsArticlesController : Controller
    {
        private readonly News_PublishingDataContext _context;

        SignInManager<IdentityUser> SignInManager;
        UserManager<IdentityUser> UserManager;



        public NewsArticlesController(News_PublishingDataContext context,
            SignInManager<IdentityUser> SignInManager,
        UserManager<IdentityUser> UserManager
           
            
            )
        {
            this.SignInManager = SignInManager;
            this.UserManager = UserManager;
            _context = context;
        }

        // GET: NewsArticles
        //Get all news articles
        [Authorize(Roles = "site_admin")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.NewsArticle.ToListAsync());
        }

        // GET: NewsArticles/Details/5
        //Get the article details

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newsArticle = await _context.NewsArticle
                .FirstOrDefaultAsync(m => m.Id == id);
            if (newsArticle == null)
            {
                return NotFound();
            }

            return View(newsArticle);
        }

        //Create  article form site admin and reporter permission 
        // GET: NewsArticles/Create
        [Authorize(Roles = "site_admin,reporter")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: NewsArticles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //Creates an article site admin and reporter

        [Authorize(Roles = "site_admin,reporter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Headline,Content,PublishedTime")] NewsArticle newsArticle)
        {
            if (ModelState.IsValid)
            {

                if (SignInManager.IsSignedIn(User)) {

                    newsArticle.PublishedTime = System.DateTime.Now;
                    _context.Add(newsArticle);
                    await _context.SaveChangesAsync();


                    var reporter = (from reporters in _context.Reporter
                                    where reporters.EmailAddress.Equals(User.Identity.Name)
                                    select reporters).FirstOrDefault();

                    Publication publication = new Publication();

                    publication.NewsArticleId = newsArticle.Id;
                    publication.ReporterId = reporter.Id;

                    _context.Publication.Add(publication);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index), "Publications" );
                }
            }
            return View(newsArticle);
        }

        // GET: NewsArticles/Edit/5
        //Updates an article form  admin and reporter permission
        [Authorize(Roles = "site_admin,reporter")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newsArticle = await _context.NewsArticle.FindAsync(id);
            if (newsArticle == null)
            {
                return NotFound();
            }
            return View(newsArticle);
        }

        // POST: NewsArticles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //Update  news article permission site admin and reported
        [Authorize(Roles = "site_admin,reporter")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Headline,Content,PublishedTime")] NewsArticle newsArticle)
        {
            if (id != newsArticle.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(newsArticle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewsArticleExists(newsArticle.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), "Publications");
            }
            return View(newsArticle);
        }

        // GET: NewsArticles/Delete/5
        //Delete form site admin and reported permission
        [Authorize(Roles = "site_admin,reporter")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newsArticle = await _context.NewsArticle
                .FirstOrDefaultAsync(m => m.Id == id);
            if (newsArticle == null)
            {
                return NotFound();
            }

            return View(newsArticle);
        }

        // POST: NewsArticles/Delete/5
        //Deletes the news article
        [Authorize(Roles = "site_admin,reporter")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var newsArticle = await _context.NewsArticle.FindAsync(id);
            _context.NewsArticle.Remove(newsArticle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), "Publications");
        }

        //Check article exists using  lamda query
        private bool NewsArticleExists(int id)
        {
            return _context.NewsArticle.Any(e => e.Id == id);
        }
    }
}
