using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Olbp.Models;
using WebApplication9.Models;

namespace Olbp.Controllers
{
    public class NewOrganisationsController : Controller
    {
        private OlbpContext db = new OlbpContext();

        // GET: NewOrganisations
        public async Task<ActionResult> Index()
        {
            return View(await db.Organisations.ToListAsync());
        }

        // GET: NewOrganisations/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Organisations organisations = await db.Organisations.FindAsync(id);
            if (organisations == null)
            {
                return HttpNotFound();
            }
            return View(organisations);
        }

        // GET: NewOrganisations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewOrganisations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,Nomenklature,Edrpou,Account,Mfo,Bankname,Tarif,Percent,Minsum,Enabled,CityId,UserId,Unconfirmed,Contract_Num,Contract_Date,ResendType,CanSavePayer,CanSaveAccount,FileFolder,ExportEveryday,IsMounthProfit,IsArchive,ReceiverGroup,PayersCheck,IsUsedGeneralTemplate,LockedTime,Additional,UseAdditionalyService,ParentId,Use_AutoDefaults,ReducedTypeId,Visibility,LocationId,ReceivingTypeId,WebserviceId,DateCreate,NomenklatureComission,ExtServiceId")] Organisations organisations)
        {
            if (ModelState.IsValid)
            {
                db.Organisations.Add(organisations);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(organisations);
        }

        // GET: NewOrganisations/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Organisations organisations = await db.Organisations.FindAsync(id);
            if (organisations == null)
            {
                return HttpNotFound();
            }
            return View(organisations);
        }

        // POST: NewOrganisations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<ActionResult> Edit([Bind(Include = "Id,Name,Nomenklature,Edrpou,Account,Mfo,Bankname,Tarif,Percent,Minsum,Enabled,CityId,UserId,Unconfirmed,Contract_Num,Contract_Date,ResendType,CanSavePayer,CanSaveAccount,FileFolder,ExportEveryday,IsMounthProfit,IsArchive,ReceiverGroup,PayersCheck,IsUsedGeneralTemplate,LockedTime,Additional,UseAdditionalyService,ParentId,Use_AutoDefaults,ReducedTypeId,Visibility,LocationId,ReceivingTypeId,WebserviceId,DateCreate,NomenklatureComission,ExtServiceId")] Organisations organisations)
        public async Task<ActionResult> Edit(Organisations organisations)
        {
            if (ModelState.IsValid)
            {
                db.Entry(organisations).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(organisations);
        }

        // GET: NewOrganisations/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Organisations organisations = await db.Organisations.FindAsync(id);
            if (organisations == null)
            {
                return HttpNotFound();
            }
            return View(organisations);
        }

        // POST: NewOrganisations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Organisations organisations = await db.Organisations.FindAsync(id);
            db.Organisations.Remove(organisations);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
