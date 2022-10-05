using AppViews.Models;
using Data.ModelsClass;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace AppViews.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            List<Sanpham> sanphams = new List<Sanpham>();
            var httpClient = new HttpClient(); //tạo 1 http Client để call API
            var response = await httpClient.GetAsync("https://localhost:7102/api/Sanphams/-get-all-sanpham");
            // Lấy dữ liệu từ file Json - Cài nuget Newtonsoft.json
            // Đọc ra 1 file Json
            string sanphamResponse = await response.Content.ReadAsStringAsync();
            // Lấy ra list object từ string json
            sanphams = JsonConvert.DeserializeObject<List<Sanpham>>(sanphamResponse);
            return View(sanphams);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}