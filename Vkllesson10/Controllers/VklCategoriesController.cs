using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vkllesson10.Models;

namespace Vkllesson10.Controllers
{
    public class VklCategoriesController : Controller
    {
        private readonly Vklk23cnt2lesson10DbContext _context;

        public VklCategoriesController(Vklk23cnt2lesson10DbContext context)
        {
            _context = context;
        }

        // GET: VklCategories
        public async Task<IActionResult> VklIndex()
        {
            return View(await _context.VklCategories.ToListAsync());
        }

        // GET: VklCategories/Details/5
        public async Task<IActionResult> VklDetails(int? vklId)
        {
            if (vklId == null)
            {
                return NotFound();
            }

            var vklCategory = await _context.VklCategories
                .FirstOrDefaultAsync(m => m.CateId == vklId);
            if (vklCategory == null)
            {
                return NotFound();
            }

            return View(vklCategory);
        }

        // GET: VklCategories/Create
        public IActionResult VklCreate()
        {
            return View();
        }

        // POST: VklCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> VklCreate([Bind("CateId,CateName,CateStatus")] VklCategory vklCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vklCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(VklIndex));
            }
            return View(vklCategory);
        }

        // GET: VklCategories/Edit/5
        public async Task<IActionResult> VklEdit(int? vklId)
        {
            if (vklId == null)
            {
                return NotFound();
            }

            var vklCategory = await _context.VklCategories.FindAsync(vklId);
            if (vklCategory == null)
            {
                return NotFound();
            }
            return View(vklCategory);
        }

        // POST: VklCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> VklEdit(int vklId, [Bind("CateId,CateName,CateStatus")] VklCategory vklCategory)
        {
            if (vklId != vklCategory.CateId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vklCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VklCategoryExists(vklCategory.CateId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(VklIndex));
            }
            return View(vklCategory);
        }

        // GET: VklCategories/Delete/5
        public async Task<IActionResult> VklDelete(int? vklId)
        {
            if (vklId == null)
            {
                return NotFound();
            }

            var vklCategory = await _context.VklCategories
                .FirstOrDefaultAsync(m => m.CateId == vklId);
            if (vklCategory == null)
            {
                return NotFound();
            }

            return View(vklCategory);
        }

        // POST: VklCategories/Delete/5
        [HttpPost, ActionName("VklDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> VklDeleteConfirmed(int vklId)
        {
            var vklCategory = await _context.VklCategories.FindAsync(vklId);
            if (vklCategory != null)
            {
                _context.VklCategories.Remove(vklCategory);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(VklIndex));
        }

        private bool VklCategoryExists(int vklId)
        {
            return _context.VklCategories.Any(e => e.CateId == vklId);
        }
    }
}
