using sessionTpDIP.ViewModels;

namespace sessionTpDIP.Repositories
{
    public interface ITodoService
    {
        public void Add(AddTodoVm vm, HttpContext context);
        public List<ListTodoVm> GetAll(HttpContext context);
        public EditTodoVm FindById(int id, HttpContext context);
        public void Update(int id, EditTodoVm vm, HttpContext context);
        public void Delete(int id, HttpContext context);
    }
}
