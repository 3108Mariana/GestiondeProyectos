using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GestiondeProyectos.Models;

namespace GestiondeProyectos.Controllers
{
    public class GestionsController : Controller
    {
        private proyectobd db = new proyectobd();

        // GET: Gestions
        public async Task<ActionResult> Index()
        {
            return View(await db.gestion.ToListAsync());
        }

        // GET: Gestions/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gestion gestion = await db.gestion.FindAsync(id);
            if (gestion == null)
            {
                return HttpNotFound();
            }
            return View(gestion);
        }

        // GET: Gestions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Gestions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,Nombre,Apellido_Paterno,Apellido_Materno,Nombre_Proyecto,Tiempo,Nombre_tareas,Rol_Asignado,Numero_actividades")] Gestion gestion)
        {
            if (ModelState.IsValid)
            {
                db.gestion.Add(gestion);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(gestion);
        }

        // GET: Gestions/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gestion gestion = await db.gestion.FindAsync(id);
            if (gestion == null)
            {
                return HttpNotFound();
            }
            return View(gestion);
        }

        // POST: Gestions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,Nombre,Apellido_Paterno,Apellido_Materno,Nombre_Proyecto,Tiempo,Nombre_tareas,Rol_Asignado,Numero_actividades")] Gestion gestion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gestion).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(gestion);
        }

        // GET: Gestions/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gestion gestion = await db.gestion.FindAsync(id);
            if (gestion == null)
            {
                return HttpNotFound();
            }
            return View(gestion);
        }

        // POST: Gestions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Gestion gestion = await db.gestion.FindAsync(id);
            db.gestion.Remove(gestion);
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
