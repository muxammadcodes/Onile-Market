using Microsoft.AspNetCore.Mvc;
using OnlineMarket.Domain.Entities;
using OnlineMarket.Service.DTOs;
using OnlineMarket.Service.Interfaces;


namespace YourNamespace.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await this._productService.RetrievAllAsync();
            return View(products);
        } 

       

        public async  Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductCreationDto dto)
        {
            if (dto is null || !ModelState.IsValid)
            {
                return View(dto);
            }

            await this._productService.AddAsync(dto);

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Details(int id)
        {
            var user = await this._productService.RetrievByIdAsync(id);
            return View(user);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var product = await this._productService.RetrievByIdAsync(id);
            return View(product);
        }
        [ActionName("Edit")]
        [HttpPost]
        public async Task<IActionResult> EditAsync(int id,ProductForResultDto dto)
        {
            var toUpdate = await this._productService.UpdateAsync(id, dto);
            if (toUpdate is null)
                return View(toUpdate);

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            var product = await this._productService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

    }
}
