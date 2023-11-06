using BoulevardResidence.Domain.Data;
using BoulevardResidence.Domain.Entity.Contacts;
using BoulevardResidence.Service.DTOs.Contact;
using BoulevardResidence.Service.DTOs.Home;
using BoulevardResidence.Service.Interfaces;
using BoulevardResidence.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BoulevardResidence.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ISliderService _sliderService;
        private readonly IInfrastructureService _infraService;
        private readonly IArchitecturalService _architecturalService;
        private readonly IArchitecturalBlogService _architecturalBlogService;
        private readonly IComfortService _comfortService;
        private readonly IComfortBlogService _comfortBlogService;
        private readonly IGalleryService _galleryService;
        private readonly IGalleryCategoryService _galleryCategoryService;
        private readonly ISliderHeaderService _sliderHeaderService;
        private readonly IBackgroundImageService _backgroundImageService;
        private readonly IEmailService _emailService;
        public HomeController(AppDbContext context, ISliderService sliderService, 
                             IInfrastructureService infraService, IArchitecturalService architecturalService,
                             IArchitecturalBlogService architecturalBlogService, IComfortService comfortService,
                             IComfortBlogService comfortBlogService, IGalleryService galleryService,
                             IGalleryCategoryService galleryCategoryService, ISliderHeaderService sliderHeaderService,
                             IBackgroundImageService backgroundImageService, IEmailService emailService)
        {
            _context = context;
            _sliderService = sliderService;
            _infraService = infraService;
            _architecturalService = architecturalService;
            _architecturalBlogService = architecturalBlogService;
            _comfortService = comfortService;
            _comfortBlogService = comfortBlogService;
            _galleryService = galleryService;
            _galleryCategoryService = galleryCategoryService;
            _sliderHeaderService = sliderHeaderService;
            _backgroundImageService = backgroundImageService;
            _emailService = emailService;
        }
        public async Task<IActionResult> Index()
        {
            var lang = Request.Cookies["SelectedLanguage"];
            if (string.IsNullOrEmpty(lang))
            {

                lang = "az";
            }
            HomeVM model = new HomeVM()
            {
                Sliders = await _sliderService.GetAllAsync(),
                Infrastructures = await _infraService.GetAllAsync(),
                Architecturals = await _architecturalService.GetAllAsync(),
                ArchitecturalBlogs = await _architecturalBlogService.GetAllAsync(),
                Comforts = await _comfortService.GetAllAsync(),
                ComfortBlogs = await _comfortBlogService.GetAllAsync(),
                GalleryItems = await _galleryService.GetAllAsync(), //bunu duzelt
                GalleryCategories = await _galleryCategoryService.GetAllAsync(),
                SliderHeaders = await _sliderHeaderService.GetAllAsync(),
                SectionBackgroundImages = await _backgroundImageService.GetAllAsync(),
                LangCode = lang.ToLower()

            };
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //public string DetermineLanguageFromBrowserSettings()
        //{
        //    // Kullanıcının tarayıcı ayarlarını kontrol edin
        //    string[] userLanguages = Request.Headers["Accept-Language"].ToString().Split(',');

        //    // Öncelikli olarak, tarayıcının belirlediği ilk dil kullanılabilir
        //    if (userLanguages.Length > 0)
        //    {
        //        // İlk dil kodunu alın (örneğin, "en-US")
        //        string browserLanguage = userLanguages[0]?.Trim();

        //        // İstenilen dil kodu formatına çevirebilirsiniz (örneğin, "en-US" -> "en-US")
        //        return browserLanguage;
        //    }

        //    // Eğer tarayıcı ayarları yoksa veya tanınmış bir dil yoksa, bir varsayılan dil belirleyin
        //    return "en-US"; // Varsayılan dil kodu
        //}

        [HttpPost]
        public IActionResult WaitCall(string name,string phoneNumber)
        {
            string to = "ibrahimliyev7@gmail.com"; // E-posta alıcısını belirleyin
            string subject = "Wait For Call"; // E-posta konusunu belirleyin
            string html = $"Name: {name}, Phone Number: {phoneNumber}"; // E-posta içeriğini oluşturun

            // E-postayı göndermek için EmailService'i kullanın
            _emailService.Send(to, subject, html);

            return View("Index");
        }



    }
}
