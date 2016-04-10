using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Biketravelby.Int.Core;
using Biketravelby.Int.Models;

namespace Biketravelby.Int.Controllers
{
    public class ClientsController : Controller
    {
        private ClientDBContext db = new ClientDBContext();

        // GET: Clients
        public ActionResult Index()
        {
            IEnumerable<ClientsModel> model = new List<ClientsModel>();
            model = (IEnumerable<ClientsModel>)db.Clients.ToList();
            
            return View(model);
        }

        // GET: Clients/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = db.Clients.Find(id);
            ClientsModel model = new ClientsModel() { Name = client.Name, ID = client.ClientID, Birthday = client.Birthday, Surname = client.Surname };
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // GET: Clients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Surname,Birthday")] ClientsModel clientsModel)
        {
            if (ModelState.IsValid)
            {
                db.ClientsModels.Add(clientsModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clientsModel);
        }

        // GET: Clients/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientsModel clientsModel = db.ClientsModels.Find(id);
            if (clientsModel == null)
            {
                return HttpNotFound();
            }
            return View(clientsModel);
        }

        // POST: Clients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Surname,Birthday")] ClientsModel clientsModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clientsModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clientsModel);
        }

        // GET: Clients/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientsModel clientsModel = db.ClientsModels.Find(id);
            if (clientsModel == null)
            {
                return HttpNotFound();
            }
            return View(clientsModel);
        }

        // POST: Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClientsModel clientsModel = db.ClientsModels.Find(id);
            db.ClientsModels.Remove(clientsModel);
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
