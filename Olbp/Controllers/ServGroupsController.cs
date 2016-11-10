using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using System.Threading.Tasks;
using Olbp.Models;
using WebApplication9.Models;
using System.Data.Entity;

namespace Olbp.Controllers
{
    public class ServGroupsController : Controller
    {
        public OlbpContext Context;
        public ServGroupsController()
        {
            Context = new OlbpContext();
        }


        // GET: ServGroups
        public async Task<ActionResult> ServGroupsAll(int? page)
        {
            ViewBag.Title = "Групи послуг";
            int itemsPerPage = 10;

            var list = await Task.Run(() => Context.ServGroup.OrderBy(x => x.name).ToList());

            var pageNumber = page ?? 1;
            var onePage = list.ToPagedList(pageNumber, itemsPerPage);

            ViewBag.OnePageOfServGroups = onePage;
            return View();
        }

        public async Task<ActionResult> EditServGroup(int id)
        {
            ServGroup content = await Task.Run(() => Context.ServGroup.Where(x => x.id == id).ToList()[0]);
            ViewBag.Title = content.name;

            return View(content);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditServGroup(ServGroup group, string command = "", string modalCommand = "")
        {
            if (command.Equals("Save"))
            {
                if (ModelState.IsValid)
                {
                    Context.Entry(group).State = EntityState.Modified;
                    await Context.SaveChangesAsync();
                    ViewBag.Title = group.name;
                }
                return View(group);
            }
            //else if (command.Equals("Exit"))
            //{
            //    return RedirectToAction("ServGroupsAll");
            //}

            return RedirectToAction("ServGroupsAll");
        }
    }
}