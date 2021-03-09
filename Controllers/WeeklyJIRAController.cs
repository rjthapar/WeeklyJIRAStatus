using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeeklyJIRAStatus.Models;

namespace WeeklyJIRAStatus.Controllers
{
    public class WeeklyJIRAController : Controller
    {
        private readonly WeeklyJIRAContext _Db;
        public WeeklyJIRAController(WeeklyJIRAContext Db)
        {
            _Db = Db;
        }
        public IActionResult WeeklyJIRA()
        {
            var res = _Db.Weekly_JIRA.ToList();
            return View(res);
        }

        public IActionResult Create(WeeklyJIRA obj)
        {
            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> AddJIRA(WeeklyJIRA obj)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    if(obj.Id == 0)
                    {
                        _Db.Weekly_JIRA.Add(obj);
                        await _Db.SaveChangesAsync();
                    }
                    else
                    {
                        _Db.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        await _Db.SaveChangesAsync();
                    }
                    
                    return RedirectToAction("WeeklyJIRA");
                }
                
                return View();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return RedirectToAction("WeeklyJIRA");
            }
            
        }

        public async Task<IActionResult> DeleteJIRA(int id)
        {
            var res = await _Db.Weekly_JIRA.FindAsync(id);
            if(res != null)
            {
                _Db.Weekly_JIRA.Remove(res);
                await _Db.SaveChangesAsync();
            }
            return RedirectToAction("WeeklyJIRA");
        }
    }
}
