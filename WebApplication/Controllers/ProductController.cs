using BusinessLogic;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult InsertIntoProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InsertIntoProduct(ProductModel pm)
        {
            try
            {
                DTO dto = new DTO()
                {
                    ProductName = pm.ProductName,
                    ProductGroupName = pm.ProductGroupName,

                };
                BL bl = new BL();
                int result = bl.InsertIntoProduct(dto);
                if (result == 1)
                {
                    return View("Success");
                }
                else
                {
                    return View("Error");
                }

            }
            catch (Exception ex)
            {

                return View("Error");
            }

        }
    }
}