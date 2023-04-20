using Microsoft.AspNetCore.Mvc;
using SalesWebMvc2019.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc2019.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerservice)
        {
            _sellerService = sellerservice;
        }
        public IActionResult Index()
        {
            var list = _sellerService.Findall();
            return View(list);
        }
    }
}
