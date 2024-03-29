﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspTutorialMVC.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspTutorialMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            /* Build the products model. It is NOT RECOMMENDED to build   
             * models in Controller action methods  like this. 
             * In real world appication, these models and the    
             * respective Data Access Layer(DAL) would  be in separate projects. 
             * We are creating it here to make things    
             * simpler to explain */

            List<Product> Products2 = new List<Product>
            {
                new Product
                {
                    Name = "Mobile Phone",
                    Price = 300
                },
                new Product
                {
                    Name = "Laptop",
                    Price = 1000
                },
                new Product
                {
                    Name = "Tablet",
                    Price = 600
                }
            };

            Order order = new Order
            {
                Products = Products2,
                Total = Products2.Sum(product => product.Price)
            };

            return View(order);
        }
    }
}
