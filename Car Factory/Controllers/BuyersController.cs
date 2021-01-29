using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Car_Factory.Data;
using Car_Factory.Models;
using Microsoft.AspNetCore.Authorization;

namespace Car_Factory.Controllers
{
    [Authorize]
    public class BuyersController : Controller
    {
        private readonly Car_FactoryContext _context;

        public BuyersController(Car_FactoryContext context)
        {
            _context = context;
        }

        // GET: Buyers
        public async Task<IActionResult> Index()
        {
            var car_FactoryContext = _context.Buyer.Include(b => b.Seller_ID);
            return View(await car_FactoryContext.ToListAsync());
        }

        // GET: Buyers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buyer = await _context.Buyer
                .Include(b => b.Seller_ID)
                .FirstOrDefaultAsync(m => m.BuyerID == id);
            if (buyer == null)
            {
                return NotFound();
            }

            return View(buyer);
        }
        [Authorize]
        // GET: Buyers/Create
        public IActionResult Create()
        {
            ViewData["SellerID"] = new SelectList(_context.Seller, "SellerID", "SellerName");
            return View();
        }

        // POST: Buyers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BuyerID,BuyerName,ContactNumber,BuyerAddress,SellerID")] Buyer buyer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(buyer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SellerID"] = new SelectList(_context.Seller, "SellerID", "SellerID", buyer.SellerID);
            return View(buyer);
        }
        [Authorize]
        // GET: Buyers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buyer = await _context.Buyer.FindAsync(id);
            if (buyer == null)
            {
                return NotFound();
            }
            ViewData["SellerID"] = new SelectList(_context.Seller, "SellerID", "SellerName", buyer.SellerID);
            return View(buyer);
        }

        // POST: Buyers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BuyerID,BuyerName,ContactNumber,BuyerAddress,SellerID")] Buyer buyer)
        {
            if (id != buyer.BuyerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(buyer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BuyerExists(buyer.BuyerID))
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
            ViewData["SellerID"] = new SelectList(_context.Seller, "SellerID", "SellerName", buyer.SellerID);
            return View(buyer);
        }

        // GET: Buyers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buyer = await _context.Buyer
                .Include(b => b.Seller_ID)
                .FirstOrDefaultAsync(m => m.BuyerID == id);
            if (buyer == null)
            {
                return NotFound();
            }

            return View(buyer);
        }

        // POST: Buyers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var buyer = await _context.Buyer.FindAsync(id);
            _context.Buyer.Remove(buyer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BuyerExists(int id)
        {
            return _context.Buyer.Any(e => e.BuyerID == id);
        }
    }
}
