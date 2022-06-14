using Charts.Data;
using Microsoft.AspNetCore.Mvc;


namespace Charts.Controllers
{
    public class ChartsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ChartsController( ApplicationDbContext  db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ChartsData()
        {
            return View();
        }
        [HttpPost]
        public List<object> GetChartsData()
        {
            List<object> Tabledata = new List<object>();
            List<string> labels = _db.ChartsTables.Select(p=>p.MonthsName).ToList();
            Tabledata.Add(labels);

            List<int> Value = _db.ChartsTables.Select(p => p.Value).ToList();
            Tabledata.Add(Value);

            return Tabledata;
        }

    }
}
