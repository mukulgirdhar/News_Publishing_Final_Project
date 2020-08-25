using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using News_Publishing_Final_Project.Models;
using System.Linq;
using System.Threading.Tasks;

namespace News_Publishing_Final_Project.Controllers
{

    //Reporters controller.
    [Authorize(Roles = "site_admin")]
    public class ReportersController : Controller
    {
        private readonly News_PublishingDataContext _context;

        public ReportersController(News_PublishingDataContext context)
        {
            _context = context;
        }

        // GET: Reporters
        //Gets all reporters
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reporter.ToListAsync());
        }

        // GET: Reporters/Details/5
        //Show details of reporter
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reporter = await _context.Reporter
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reporter == null)
            {
                return NotFound();
            }

            return View(reporter);
        }

      //Update reporter form.

        // GET: Reporters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reporter = await _context.Reporter.FindAsync(id);
            if (reporter == null)
            {
                return NotFound();
            }
            return View(reporter);
        }

        // POST: Reporters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //Updates the reporter
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ReportingCompany,EmailAddress")] Reporter reporter)
        {
            if (id != reporter.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reporter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReporterExists(reporter.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(reporter);
        }

        // GET: Reporters/Delete/5
        //Delete reporter form
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reporter = await _context.Reporter
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reporter == null)
            {
                return NotFound();
            }

            return View(reporter);
        }

        // POST: Reporters/Delete/5
        //Deletes the reporter.
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reporter = await _context.Reporter.FindAsync(id);
            _context.Reporter.Remove(reporter);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReporterExists(int id)
        {
            return _context.Reporter.Any(e => e.Id == id);
        }
    }
}
