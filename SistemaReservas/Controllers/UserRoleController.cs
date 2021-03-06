﻿using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaReservas.Controllers
{
    public class UserRoleController : BaseController
    {
        private IdentityUserManager _userManager;
        private IdentityRoleManager _roleManager;

        public IdentityRoleManager RoleManager
        {
            get
            {
                return _roleManager ?? HttpContext.GetOwinContext().Get<IdentityRoleManager>();
            }
            private set
            {
                _roleManager = value;
            }
        }


        public IdentityUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<IdentityUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        // GET: UserRole
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserRole/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserRole/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserRole/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserRole/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserRole/Edit/5
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

        // GET: UserRole/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserRole/Delete/5
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
