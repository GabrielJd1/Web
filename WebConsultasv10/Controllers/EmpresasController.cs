﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebConsultasv10.Models;

namespace WebConsultasv10.Controllers
{
    public class EmpresasController : Controller
    {
        private WebConsultasContext db = new WebConsultasContext();

        // GET: Empresas
        public ActionResult Index()
        {
            return View(db.Empresas.ToList());
        }

        // GET: Empresas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empresas empresas = db.Empresas.Find(id);
            if (empresas == null)
            {
                return HttpNotFound();
            }
            return View(empresas);
        }

        // GET: Empresas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empresas/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdEmpresa,Cnpj,NomeFan,NomeRazao")] Empresas empresas)
        {
            if (ModelState.IsValid)
            {
                db.Empresas.Add(empresas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(empresas);
        }

        // GET: Empresas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empresas empresas = db.Empresas.Find(id);
            if (empresas == null)
            {
                return HttpNotFound();
            }
            return View(empresas);
        }

        // POST: Empresas/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdEmpresa,Cnpj,NomeFan,NomeRazao")] Empresas empresas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empresas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empresas);
        }

        // GET: Empresas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empresas empresas = db.Empresas.Find(id);
            if (empresas == null)
            {
                return HttpNotFound();
            }
            return View(empresas);
        }

        // POST: Empresas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Empresas empresas = db.Empresas.Find(id);
            db.Empresas.Remove(empresas);
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
