﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Ecommerces_asp.net.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ecommerces_asp.net.Areas.Admin.Data;


namespace Ecommerces_asp.net.Controllers
{
    
    public class HomeController : Controller
    {
        //private readonly DPContext _context;
        //public HomeController(DPContext context)
        //{
        //    _context = context;
        //}

        private readonly MarketContext _context;
        public HomeController(MarketContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Products = _context.Products;
            
            var products = (from Product in _context.Products
                            orderby Product.Id descending
                            select Product).Take(4).ToList();

            ViewBag.Product = products;
            ViewBag.Categoris = _context.Categories;
            var cate = (from Category in _context.Categories
                        orderby Category.Id descending
                        select Category).ToList();
            ViewBag.category = cate;
            ViewBag.Supplier = _context.Suppliers;
            return View();

          

            //var marketContext = _context.Products.Include(p => p.Category).Include(p => p.Supplier);
            //return View(await marketContext.ToListAsync());
            //var drink = _context.Products;
            //return View(drink);
            //var model = _context.Categories;
            //return PartialView("_CategoryPartial", model);
        }
       
        public IActionResult Category()
        {
            return View();
            //List<Category> clist = _context.Categories.ToList();
            //return PartialView("_CategoryPartial", clist);
            
        }
        public IActionResult about()
        {
            return View();
        }
        public IActionResult checkout()
        {
            return View();
        }
        public IActionResult contact()
        {
            return View();
        }
        public IActionResult Offer()
        {
            return View();
        }
        public IActionResult product()
        {
            return View();
        }
        public IActionResult registered()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }
        public IActionResult detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewBag.products = _context.Products.FirstOrDefaultAsync(m => m.Id == id);
            if (ViewBag.products == null)
            {
                return NotFound();
            }

            return View();
        }
    }
}
