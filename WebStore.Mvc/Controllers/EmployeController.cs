using Microsoft.AspNetCore.Mvc;
using WebStore.Mvc.Models;
using WebStore.Mvc.Infrastructure.Interfaces;

namespace WebStore.Mvc.Controllers
{
    public class EmployeController : Controller
    {
        private readonly IRepository<EmployeViewModel> _employeRepo;
        public EmployeController (IRepository<EmployeViewModel> repository) => _employeRepo = repository;

        public IActionResult Index()
        {
            return View(_employeRepo.GetAll());
        }

        public IActionResult View(int id)
        {
            var employee = _employeRepo.GetById(id);

            if(employee == null) 
                return NotFound();

            return View(employee);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(_employeRepo.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(EmployeViewModel data)
        {
            _employeRepo.Update(data);
            return View();
        }

        public IActionResult Delete(int id)
        {
            if (!_employeRepo.Delete(id))
                throw new Exception();

            return RedirectToAction(nameof(Index));
        }
    }
}
