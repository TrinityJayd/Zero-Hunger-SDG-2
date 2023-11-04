using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Zero_Hunger_SDG_2.Models;

namespace Zero_Hunger_SDG_2.Controllers
{
    public class CropController : Controller
    {
        private readonly CropRepository _cropRepository;

        public CropController(CropRepository cropRepository)
        {
            _cropRepository = cropRepository;
        }

        public ActionResult Index()
        {
            var crops = _cropRepository.GetAll();
            return View(crops);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Crop crop)
        {
            if (ModelState.IsValid)
            {
                _cropRepository.Add(crop);
                return RedirectToAction("Index");
            }
            return View(crop);
        }

        public ActionResult Edit(int id)
        {
            var crop = _cropRepository.GetCropById(id);
            return View(crop);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmEdit(int id, Crop crop)
        {
            _cropRepository.Update(crop);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var crop = _cropRepository.GetCropById(id);
            return View(crop);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(int id)
        {
            _cropRepository.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Stats()
        {
            var totalsViewModel = new TotalsViewModel
            {
                TotalYield = _cropRepository.TotalCropYield(),
                TotalIncome = _cropRepository.TotalCropIncome(),
                TotalExpenses = _cropRepository.TotalCropExpenses()
            };
            return View(totalsViewModel);
        }
    }
}
