using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcClient.Data;
using MvcClient.Models;

namespace MvcClient.Controllers
{
    public class SuppliersController : Controller
    {
        private readonly MvcClientContext _context;

        public SuppliersController(MvcClientContext context)
        {
            _context = context;
        }

        // GET: Suppliers
        public async Task<IActionResult> Index(string searchString, int pageNumber = 1)
        {
            if (_context.Supplier == null)
            {
                return Problem("Entity set 'MvcMovieContext.Movie'  is null.");
            }


            var suppliers = from m in _context.Supplier
                            select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                suppliers = suppliers.Where(s => s.Name!.ToUpper().Contains(searchString.ToUpper()));
            }

            int pageSize = 10;
            var paginatedSuppliers = await PaginatedList<Supplier>.CreateAsync(suppliers.AsNoTracking(), pageNumber, pageSize);

            ViewData["SearchString"] = searchString;
            ViewData["HasPreviousPage"] = paginatedSuppliers.HasPreviousPage;
            ViewData["HasNextPage"] = paginatedSuppliers.HasNextPage;
            ViewData["PageIndex"] = paginatedSuppliers.PageIndex;
            ViewData["TotalPages"] = paginatedSuppliers.TotalPages;


            return View(paginatedSuppliers);
        }

        // GET: Suppliers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplier = await _context.Supplier
                .FirstOrDefaultAsync(m => m.Id == id);
            if (supplier == null)
            {
                return NotFound();
            }

            return View(supplier);
        }

        // GET: Suppliers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Suppliers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CNPJ,CompanyName,TradeName,Id,Name,Address,Phone,Email,CreatedAt,UpdatedAt")] Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                _context.Add(supplier);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Fornecedor cadastrado com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            return View(supplier);
        }

        // GET: Suppliers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplier = await _context.Supplier.FindAsync(id);
            if (supplier == null)
            {
                return NotFound();
            }
            return View(supplier);
        }

        // POST: Suppliers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CNPJ,CompanyName,TradeName,Id,Name,Address,Phone,Email,CreatedAt,UpdatedAt")] Supplier supplier)
        {
            if (id != supplier.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(supplier);
                    await _context.SaveChangesAsync();
                    TempData["Success"] = "Fornecedor Editado com sucesso!";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SupplierExists(supplier.Id))
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
            return View(supplier);
        }

        // GET: Suppliers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplier = await _context.Supplier
                .FirstOrDefaultAsync(m => m.Id == id);
            if (supplier == null)
            {
                return NotFound();
            }

            return View(supplier);
        }

        // POST: Suppliers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var supplier = await _context.Supplier.FindAsync(id);
            if (supplier != null)
            {
                _context.Supplier.Remove(supplier);
                TempData["Success"] = "Fornecedor deletado com sucesso!";
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SupplierExists(int id)
        {
            return _context.Supplier.Any(e => e.Id == id);
        }
    }
}
