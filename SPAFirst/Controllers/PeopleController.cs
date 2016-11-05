using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SPAFirst.DAL;
using SPAFirst.Models;
using System.Globalization;

namespace SPAFirst.Controllers
{
	public partial class PeopleController : Controller
	{
		private DatabaseContext db = new DatabaseContext();

		public PeopleController()
		{
			CultureInfo oCultureInfo;

			oCultureInfo = new CultureInfo("en-US");
			oCultureInfo = new CultureInfo("fa-IR");

			System.Threading.Thread.CurrentThread.CurrentCulture = oCultureInfo;
			System.Threading.Thread.CurrentThread.CurrentUICulture = oCultureInfo;

		}
		// GET: People
		public virtual ActionResult Index()
		{
			return View(db.People.ToList());
		}

		// GET: People/Details/5
		public virtual ActionResult Details(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Person person = db.People.Find(id);
			if (person == null)
			{
				return HttpNotFound();
			}
			return View(person);
		}

		// GET: People/Create
		public virtual ActionResult Create()
		{
			return View();
		}

		// POST: People/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public virtual ActionResult Create([Bind(Include = "PersonID,FirstName,LastName,Title,IsActive")] Person person)
		{
			if (ModelState.IsValid)
			{
				db.People.Add(person);
				db.SaveChanges();
				return RedirectToAction("Index");
			}

			return View(person);
		}

		// GET: People/Edit/5
		public virtual ActionResult Edit(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Person person = db.People.Find(id);
			if (person == null)
			{
				return HttpNotFound();
			}
			return View(person);
		}

		// POST: People/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public virtual ActionResult Edit([Bind(Include = "PersonID,FirstName,LastName,Title,IsActive")] Person person)
		{
			if (ModelState.IsValid)
			{
				db.Entry(person).State = EntityState.Modified;
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(person);
		}

		// GET: People/Delete/5
		public virtual ActionResult Delete(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Person person = db.People.Find(id);
			if (person == null)
			{
				return HttpNotFound();
			}
			return View(person);
		}

		// POST: People/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public virtual ActionResult DeleteConfirmed(int id)
		{
			Person person = db.People.Find(id);
			db.People.Remove(person);
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
