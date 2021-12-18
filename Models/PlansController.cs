﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace MPlan.Models
{
    public class PlansController : Controller
    {
        private readonly MPlanContext _context;

        public PlansController(MPlanContext context)
        {
            _context = context;
        }

        // GET: Plans
        public async Task<IActionResult> Index()
        {
            return View(await _context.DBPlan.ToListAsync());
        }

        // GET: Plans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plans = await _context.DBPlan
                .FirstOrDefaultAsync(m => m.Id == id);
            if (plans == null)
            {
                return NotFound();
            }

            return View(plans);
        }

        // GET: Plans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Plans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PlanType,StartDate,EndDate,CPercent,UsageType,ItemId,UserId")] Plans plans)
        {
            if (ModelState.IsValid)
            {
                _context.Add(plans);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(plans);
        }

        // GET: Plans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plans = await _context.DBPlan.FindAsync(id);
            if (plans == null)
            {
                return NotFound();
            }
            return View(plans);
        }

        // POST: Plans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PlanType,StartDate,EndDate,CPercent,UsageType,ItemId,UserId")] Plans plans)
        {
            if (id != plans.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(plans);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlansExists(plans.Id))
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
            return View(plans);
        }

        // GET: Plans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plans = await _context.DBPlan
                .FirstOrDefaultAsync(m => m.Id == id);
            if (plans == null)
            {
                return NotFound();
            }

            return View(plans);
        }

        // POST: Plans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var plans = await _context.DBPlan.FindAsync(id);
            _context.DBPlan.Remove(plans);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlansExists(int id)
        {
            return _context.DBPlan.Any(e => e.Id == id);
        }
    }
}
