﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class EmployeeController : Controller
    {
        public ApplicationDbContext db;
        public EmployeeController()
        {
            db = new ApplicationDbContext();
        }
        //Create a view for adding a charge
        // GET: Employee
        public ActionResult Index()
        {
            string id = User.Identity.GetUserId();
            Employee employee = db.Employees.Where(e => e.ApplicationId == id).FirstOrDefault();
            //var todaysDate = DateTime.Today.DayOfWeek.ToString();
            //var thing = db.Customers.Where(c => c.ZipCode == employee.ZipCode && c.SpecificPickUpDate == todaysDate).ToList();
            return View(employee);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            Employee employee = db.Employees.Find(id);
            return View(employee);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            Employee employee = new Employee();
            return View(employee);
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            try
            {
                // TODO: Add insert logic here
                employee.ApplicationId = User.Identity.GetUserId();
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
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
