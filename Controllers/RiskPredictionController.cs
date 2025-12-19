using CaprarSalajan_AnaCezara_Lab5.Models;
using CaprarSalajan_AnaCezara_Lab5.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CaprarSalajan_AnaCezara_Lab5.Controllers
{
    public class RiskPredictionController : Controller
    {
        private readonly IRiskPredictionService _riskService;
        public RiskPredictionController(IRiskPredictionService riskService)
        {
            _riskService = riskService;
        }
        // GET: /RiskPrediction/Inde
        [HttpGet]
        public IActionResult Index()
        {
            var model = new RiskPredictionViewModel();
            return View(model);
        }
        // POST: /RiskPrediction/Index
        [HttpPost]
        public async Task<IActionResult> Index(RiskPredictionViewModel model)
        {
            var input = new RiskInput
            {
                InspectionType = model.InspectionType?.Trim(),
                ViolationDescription = model.ViolationDescription?.Trim()
            };

            model.PredictedRisk = await _riskService.PredictRiskAsync(input);

            return View(model);
        }
    }
}
