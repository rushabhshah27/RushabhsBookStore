using Microsoft.AspNetCore.Mvc;
using RushabhsBooks.DataAccess.Repository.IRepository;
using RushabhsBooks.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using RushabhsBooks.Models.ViewModels;

namespace RushabhsBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Upsert(int? id) //Get Action method for Upsert
        {
            ProductVM productVM = new ProductVM()
            {
                Product = new Product(),
                CategoryList = _unitOfWork.Category.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),
                CoverTypeList = _unitOfWork.CoverType.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),
            }; // using RushabhsBooks.Models;
            if (id == null)
            {
                //This is for create
                return View(productVM);
            }
            //This is for Edit
            productVM.Product = _unitOfWork.Product.Get(id.GetValueOrDefault());
            if (productVM.Product == null)
            {
                return NotFound();
            }
            return View(productVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Product product)
        {
            if(ModelState.IsValid)
            {
                if (product.Id == 0)
                {
                    _unitOfWork.Product.Add(product);
                }
                else
                {
                    _unitOfWork.Product.Update(product);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }
        //API calls here
        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            var allObj = _unitOfWork.Product.GetAll(includeProperties: "Category,CoverType");
            return Json(new { data = allObj });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Product.Get(id);
            if (objFromDb == null) 
            { 
                //return NotFound();
                return Json(new {success = false, message = "Error while deleting"});
            }
            _unitOfWork.Product.Remove(objFromDb); ;
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete successful" });
        }
        #endregion
    }
}