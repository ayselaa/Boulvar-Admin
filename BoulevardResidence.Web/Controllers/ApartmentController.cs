using BoulevardResidence.Domain.Data;
using BoulevardResidence.Domain.Entity.Apartments;
using BoulevardResidence.Service.DTOs.Aparments;
using BoulevardResidence.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BoulevardResidence.Web.Controllers
{
    public class ApartmentController : Controller
    {
        private readonly IApartmentService _apartmentService;
        private readonly AppDbContext _context;
        public ApartmentController(IApartmentService apartmentService)
        {
            _apartmentService = apartmentService;
        }

        public async Task<IActionResult> Index()
        {
            var buildings = _apartmentService.GetBuildings();

           
            var sortedBuildings = buildings.OrderBy(b => b).ToList();

          
            ViewBag.Buildings = sortedBuildings;

           

            var floors= _apartmentService.GetFloors();
            var sortedFloors = floors.OrderBy(b => b).ToList();
            ViewBag.Floors = sortedFloors;

            var rooms = _apartmentService.GetRooms();
            var sortedRooms = rooms.OrderBy(r => r).ToList();
            ViewBag.Rooms = sortedRooms;

            var areas = _apartmentService.GetFloorAreas();
            var sortedAreas = areas.OrderBy(r => r).ToList();
            ViewBag.MinFloorArea = sortedAreas.Min(); // Minimum değer
            ViewBag.MaxFloorArea = sortedAreas.Max(); // Maksimum değer

            var lang = Request.Cookies["SelectedLanguage"];
            if (string.IsNullOrEmpty(lang))
            {

                lang = "az";
            }

            GetAllApartmentDto model = new GetAllApartmentDto
            {
                Apartments = await _apartmentService.GetAllAsync(),
                LangCode = lang.ToLower()
            };
            return View(model);
        }

        //[HttpPost]
        //public async Task<IActionResult> FilterApartments(string building, int floor, int room, string area, List<string> features)
        //{
        //    var filteredApartments = await _apartmentService.GetFilteredApartmentsAsync(building, floor, room, area);

        //    GetAllApartmentDto model = new GetAllApartmentDto
        //    {
        //        Apartments = filteredApartments
        //    };

        //    return View("Index", model); // Filtrelenmiş verileri Index görünümünde göster
        //}

        [HttpPost]
        public JsonResult FilterApartments(string building, int floor, int room, string? floorArea)
        {
            // Filtreleme işlemini gerçekleştirin ve sonuçları bir modelle döndürün
            var filteredApartments = _apartmentService.GetFilteredApartmentsAsync(building, floor, room, floorArea);

            var JsonData = new
            {
                data = filteredApartments
            };
            // Sonuçları JSON formatında döndürün
            return Json(JsonData);
        }


        [HttpGet]
        public async Task<IActionResult> ApartmentDetail(int? id)
        {
            var lang = Request.Cookies["SelectedLanguage"];
            if (string.IsNullOrEmpty(lang))
            {

                lang = "az";
            }
            try
            {
                if (id is null) return BadRequest();
                var dbApartment = await _apartmentService.GetFullDataByIdAsync((int)id);
                if (dbApartment is null) return NotFound();

                ApartmentDetailDto model = new()
                {
                    Id = dbApartment.Id,
                    Building = dbApartment.SectionName,
                    Floor = dbApartment.Floor,
                    Room = dbApartment.RoomsAmount,
                    SectionName=dbApartment.SectionName,
                    FloorArea = dbApartment.AreaTotal,
                    Number = dbApartment.Number,
                    ApartmentPlan = dbApartment.ApartmentPlan,
                    LangCode = lang.ToLower()

                    
                };

                return View(model);
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
                return View();
            }
        }
    }
}
