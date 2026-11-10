using BookStoreFa.Data;
using BookStoreFa.Models;
using BookStoreFa.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStoreFa.Controllers
{
    
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products =await _context.Product.ToListAsync();
            return View(products);
        }
        public IActionResult Details(int id)
        {
            //database
            var productName = "iphone";
            var productPrice = "2500";
            ViewData["proName"] = productName;
            ViewData["proPrice"] = productPrice;
            var productId = 14;
            var productBrand = "microsoft";

            ViewBag.proID = productId;
            ViewBag.proBrand= productBrand;


            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateFormRegistration(CreateProductViewModel productVM)
        {
            if(!ModelState.IsValid)
            {
                return View(productVM);
            }
            var product = new Products
            {
                Name = productVM.Name,
                Price = productVM.Price,
                IsPublished = false,
                CreatedAt = DateTime.UtcNow
            };
            // Save product to database

            return RedirectToAction("Index");
        }
    }
}
