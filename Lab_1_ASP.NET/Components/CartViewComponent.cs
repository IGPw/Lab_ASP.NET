using Microsoft.AspNetCore.Mvc;

namespace Lab_1_ASP.NET.Components {
    public class CartViewComponent : ViewComponent {
        public CartViewComponent() {

        }
        public IViewComponentResult Invoke() {
            return View();
        }
    }
}
