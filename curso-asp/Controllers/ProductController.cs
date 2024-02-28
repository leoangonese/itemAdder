using curso_asp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;

namespace curso_asp.Controllers
{
    public class ProductController : Controller
    {
        UnitOfWork.UnityOfWorkApp _uow;
        // GET: pRODUCT
        public ProductController() 
        {
            _uow = new UnitOfWork.UnityOfWorkApp();
        }
        public ActionResult Index()
        {
            return View(_uow.ProductRepository.FindAll());
        }

        // GET: pRODUCT/Details/5
        public ActionResult Details(int id)
        {
            return View(_uow.ProductRepository.FindById(id));
        }

        // GET: pRODUCT/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: pRODUCT/Create
        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                // TODO: Add insert logic 
                _uow.ProductRepository.Add(product);
                _uow.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: pRODUCT/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_uow.ProductRepository.FindById(id));
        }

        // POST: pRODUCT/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Product product)
        {
            try
            {
                // TODO: Add update logic here
                _uow.ProductRepository.Edit(product);
                _uow.Commit();  
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: pRODUCT/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_uow.ProductRepository.FindById(id));
        }

        // POST: pRODUCT/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Product product)
        {
            try
            {
                // TODO: Add delete logic 
                _uow.ProductRepository.Remove(_uow.ProductRepository.FindById(id));
                _uow.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
