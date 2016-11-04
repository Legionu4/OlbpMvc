using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Olbp.Models;
using ViewModels;
using PagedList;

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
        public ActionResult GetAllOrganisations(int? page)
        {
            ViewBag.Title = "Організації";
            int itemsPerPage = 10;
            //var view = new OrganisationsViewModel();

            var list = Context.Organisations.OrderBy(x => x.Name).ToList();

            var pageNumber = page ?? 1;
            var onePageOfItem = list.ToPagedList(pageNumber, itemsPerPage);

            ViewBag.OnePageOfOrganiosations = onePageOfItem;
            return View();
        }

        public ActionResult GetOneOrganisation(int id)
        {
            var content = Context.Organisations.Where(x => x.Id == id).ToList()[0];
            ViewBag.Title = content.Name;
            //var view = new SingleOrgViewModel();
            //view.Organisation = Context.Organisations.Where(x => x.Id == id).ToList()[0];

            return View(content);
        }
    }
}