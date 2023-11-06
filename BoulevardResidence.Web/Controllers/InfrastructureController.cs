using BoulevardResidence.Domain.Data;
using BoulevardResidence.Domain.Entity.Infrastructures;
using BoulevardResidence.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BoulevardResidence.Web.Controllers
{
    public class InfrastructureController : Controller
    {
        private readonly IInfrastructureService _infraService;
        public InfrastructureController(IInfrastructureService infraService)
        {
            _infraService = infraService;
        }
        public async Task<IActionResult> Index()
        {
            List<Infrastructure> infrastructures = await _infraService.GetAllAsync();
            return View(infrastructures);
        }
    }
}
