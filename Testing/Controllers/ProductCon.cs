using Microsoft.AspNetCore.Mvc;

namespace Testing.Controllers
{
    public class ProductCon : Controller
    {
        private readonly IProductRepo repo;

        public ProductCon(IProductRepo repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
