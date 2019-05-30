using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ClientChapterv2_Michael;

namespace ClientChapterv2_Michael.Controllers
{
    public class ClientChaptersController : Controller
    {
        private TSMAppsEntities db = new TSMAppsEntities();

        // GET: ClientChapters
        public ActionResult Index()
        {
            return View(db.ClientChapters.ToList());
        }

        // GET: ClientChapters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientChapter clientChapter = db.ClientChapters.Find(id);
            if (clientChapter == null)
            {
                return HttpNotFound();
            }
            return View(clientChapter);
        }

        // GET: ClientChapters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientChapters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClientChapterSKey,chapter,tstate,chap_name,iid,area_name,env1,env2,env3,env4,tname,taddr1,taddr2,taddr3,tcity,tzip,whokey,tran_date,uw,commander,comm_title,cid,ctype,billchap,comm_lname,phone,fax,email,oldchap,memo,cust_no,invchap,nl_tag,origcid,origiid,webadd,region,lockbox,uwblackfm,uwblackto,md_coord,commander2,commtitle2,commlname2,billchap2,email2,mspthanks,lastthank,seedname,env5,origname,clientname,chapdesig,division,active,site_id,tsm_enters,envcity,envstate,envzip,CreateDate,ModifiedDate,CreatedBy,ModifiedBy")] ClientChapter clientChapter)
        {
            if (ModelState.IsValid)
            {
                db.ClientChapters.Add(clientChapter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clientChapter);
        }

        // GET: ClientChapters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientChapter clientChapter = db.ClientChapters.Find(id);
            if (clientChapter == null)
            {
                return HttpNotFound();
            }
            return View(clientChapter);
        }

        // POST: ClientChapters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ClientChapterSKey,chapter,tstate,chap_name,iid,area_name,env1,env2,env3,env4,tname,taddr1,taddr2,taddr3,tcity,tzip,whokey,tran_date,uw,commander,comm_title,cid,ctype,billchap,comm_lname,phone,fax,email,oldchap,memo,cust_no,invchap,nl_tag,origcid,origiid,webadd,region,lockbox,uwblackfm,uwblackto,md_coord,commander2,commtitle2,commlname2,billchap2,email2,mspthanks,lastthank,seedname,env5,origname,clientname,chapdesig,division,active,site_id,tsm_enters,envcity,envstate,envzip,CreateDate,ModifiedDate,CreatedBy,ModifiedBy")] ClientChapter clientChapter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clientChapter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clientChapter);
        }

        // GET: ClientChapters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientChapter clientChapter = db.ClientChapters.Find(id);
            if (clientChapter == null)
            {
                return HttpNotFound();
            }
            return View(clientChapter);
        }

        // POST: ClientChapters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClientChapter clientChapter = db.ClientChapters.Find(id);
            db.ClientChapters.Remove(clientChapter);
            db.SaveChanges();
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
