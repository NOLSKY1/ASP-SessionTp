using Microsoft.AspNetCore.Mvc;
using sessionTpDIP.Filters;
using sessionTpDIP.Models;
using sessionTpDIP.Repositories;
using sessionTpDIP.ViewModels;

namespace sessionTpDIP.Controllers
{
    [AuthFilter]
    public class TodoController : Controller
    {
        private ITodoService _ITodoService;
        public TodoController(ITodoService ITodoService)
        {
            this._ITodoService = ITodoService;
        }

        
        public IActionResult Index()
        {
       

            List<ListTodoVm> list = _ITodoService.GetAll(HttpContext);
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(AddTodoVm vm)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            _ITodoService.Add(vm, HttpContext);
            return RedirectToAction("index");
        }
        public IActionResult Edit(int id)
        {
            EditTodoVm todoToEdit = _ITodoService.FindById(id , HttpContext);
            if(todoToEdit == null)
            {
                return NotFound("Todo with id: " + id + " was not found");
            }
            return View(todoToEdit);
        }
        [HttpPost]
        public IActionResult Edit(int id ,EditTodoVm vm)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _ITodoService.Update(id, vm, HttpContext);
            return RedirectToAction("index");
        }
        public IActionResult Delete(int id)
        {
            _ITodoService.Delete(id, HttpContext);
            return RedirectToAction("index");
        }
    }
}
