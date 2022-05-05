using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebStore.Mvc.Models;
using WebStore.Mvc.Servises.Interfaces;

namespace WebStore.Mvc.Controllers
{
    [Authorize(Roles = "admin")]
    public class EmployeController : Controller
    {
        private readonly IRepository<EmployeViewModel> _employeRepo;
        public EmployeController(IRepository<EmployeViewModel> repository) => _employeRepo = repository;

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(_employeRepo.GetAll());
        }

        [AllowAnonymous]
        public IActionResult View(int id)
        {
            var employee = _employeRepo.GetById(id);

            if (employee == null)
                return NotFound();

            return View(employee);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || !ModelState.IsValid)
                return View();
            return View(_employeRepo.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(EmployeViewModel data)
        {
            if(!ModelState.IsValid)
                return View(data);

            if (data.Id == null)
                _employeRepo.Add(data);
            else
                _employeRepo.Update(data);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            if (!_employeRepo.Delete(id))
                throw new Exception();

            return RedirectToAction(nameof(Index));
        }
    }
}
