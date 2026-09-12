using Microsoft.AspNetCore.Mvc;

namespace BTVN4.ViewComponents
{
    // Kế thừa từ ViewComponent
    public class HotProductViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var hotProducts = new List<string>
            {
                "Nồi cơm điện cao tần Nagakawa NAG0102",
                "Nồi cơm điện cao tần Nagakawa NAG0102",
                "Nồi cơm điện cao tần Nagakawa NAG0102"
            };

            return await Task.FromResult(View(hotProducts));
        }
    }
}