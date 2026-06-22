using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SportSln.Models;
using SportSln.Infrastructure;
namespace SportsStore.Pages
{
    public class CartModel : PageModel
    {
        private IStoreRepository repository;
        public CartModel(IStoreRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; } = "/";
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }
        public IActionResult OnPost(long productId, string returnUrl)
        {
            Product? product = repository.Products
            .FirstOrDefault(p => p.ProductID == productId);
            if (product != null)
            {
                Cart.AddItem(product, 1);
            }
            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long productId, string returnUrl)
        {
            var line = Cart.Lines.FirstOrDefault(cl => cl.Product.ProductID == productId);
            if (line != null)
            {
                Cart.RemoveLine(line.Product);
            }
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
