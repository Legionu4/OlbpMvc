using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Olbp.Models;
using ViewModels;
using PagedList;
using WebApplication9.Models;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Olbp.Controllers
{
    public class OrganisationsController : Controller
    {
        public OlbpContext Context;
        public OrganisationsController()
        {
            Context = new OlbpContext();
        }

        //
        // GET: /Organisations/
        public async Task<ActionResult> GetAllOrganisations(int? page)
        {
            ViewBag.Title = "Організації";
            int itemsPerPage = 20;

            var list = await Task.Run(() => Context.Organisations.OrderBy(x => x.Name).ToList());

            var pageNumber = page ?? 1;
            var onePageOfItem = list.ToPagedList(pageNumber, itemsPerPage);

            ViewBag.OnePageOfOrganiosations = onePageOfItem;
            return View();
        }

        public async Task<ActionResult> GetOneOrganisation(int id)
        {
            Organisations content = await Task.Run(() => Context.Organisations.Where(x => x.Id == id).ToList()[0]);
            ViewBag.Title = content.Name;

            return View(content);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> GetOneOrganisation(Organisations organisations, string command = "", string modalCommand = "")
        {
            if (command.Equals("Save"))
            {
                if (ModelState.IsValid)
                {
                    Context.Entry(organisations).State = EntityState.Modified;
                    await Context.SaveChangesAsync();
                    return RedirectToAction("GetOneOrganisation", new { id = organisations.Id });
                }
                return View(organisations);
            }
            else if (command.Equals("Exit"))
            {
                return RedirectToAction("GetAllOrganisations");
            }

            if (command.Equals("Delete") || modalCommand.ToUpper().Equals("OK"))
                DeleteOrganisation(organisations);
            if (modalCommand.ToUpper().Equals("CANCEL"))
                return RedirectToAction("GetOneOrganisation", new { id = organisations.Id });

            return RedirectToAction("GetAllOrganisations");
        }

        private void DeleteOrganisation(Organisations organisations)
        {
            Context.Organisations.Attach(organisations);
            Context.Organisations.Remove(organisations);
            Context.SaveChanges();
        }
    }
}