using sessionTpDIP.Models;
using sessionTpDIP.ViewModels;

namespace sessionTpDIP.Mappers
{
    public class TodoMapper
    {
        public Todo MapAddTodoVmToTodoModel(AddTodoVm vm)
        {
            return new Todo
            {
                Libelle = vm.Libelle,
                Description = vm.Description,
                State = vm.State,
                DateLimite = vm.DateLimite,
            };
        }
        public ListTodoVm MapTodoModelToListTodoVm(Todo todo)
        {
            return new ListTodoVm
            {
                Id = todo.Id,
                Libelle = todo.Libelle,
                Description = todo.Description,
                State = todo.State,
                DateLimite = todo.DateLimite,
            };
        }
        public List<ListTodoVm> MapListOfTodoModelToListOfListTodoVm(List<Todo> todos)
        {
            List<ListTodoVm> list = new List<ListTodoVm>();
            foreach(Todo todo in  todos)
            {
                list.Add(this.MapTodoModelToListTodoVm(todo));
            }
            return list;
        }
        public EditTodoVm MapTodoToEditTodoVm(Todo todo)
        {
            return new EditTodoVm
            {
                Id = todo.Id,
                Libelle = todo.Libelle,
                Description = todo.Description,
                State = todo.State,
                DateLimite = todo.DateLimite,
            };
        }
        public Todo MapEditTodoVmToTodoModel(EditTodoVm vm)
        {
            return new Todo
            {
                Id = vm.Id,
                Libelle = vm.Libelle,
                Description = vm.Description,
                State = vm.State,
                DateLimite = vm.DateLimite,
            };
        }
    }
}
