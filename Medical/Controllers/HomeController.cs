﻿using Medical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Medical.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Catalog()
        {
            MedicineModel model = new MedicineModel();
            var Medicines = model.GetMedicines();
            return View(Medicines);
        }
        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            var Model = new MedicineModel();
            return View(Model.Medicines);
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            MedicineModel model = new MedicineModel();
            try
            {
                model.Add(collection["select"], collection["image"]);
                return RedirectToAction("Catalog");

            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            MedicineModel model = new MedicineModel();
            var Medicine = model.GetMedicine(id);
            return View(Medicine);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            MedicineModel model = new MedicineModel();
            try
            {
                model.Update(id, collection["CommercialName"], collection["GenericName"], collection["Producer"]);
                return RedirectToAction("Catalog");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            MedicineModel model = new MedicineModel();
            model.delete(id);
            return RedirectToAction("Catalog");
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
