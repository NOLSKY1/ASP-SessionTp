using sessionTpDIP.Mappers;
using sessionTpDIP.Models;
using sessionTpDIP.Persisters;
using sessionTpDIP.ViewModels;
namespace sessionTpDIP.Repositories
{
    public class TodoService : ITodoService
    {
        private TodoMapper _TodoMapper;
        private SessionRepository _SessionRepository;
        public TodoService(TodoMapper todoMapper , SessionRepository SessionRepository) {
            this._TodoMapper = todoMapper;
            this._SessionRepository = SessionRepository;
        }
        public List<ListTodoVm> GetAll(HttpContext context)
        {
            List<Todo> todos = _SessionRepository.Get(context, "todos");
            List<ListTodoVm> listTodoVm = _TodoMapper.MapListOfTodoModelToListOfListTodoVm(todos);
            return listTodoVm;
        }
        public void Add(AddTodoVm vm , HttpContext context)
        {
            Todo todo = _TodoMapper.MapAddTodoVmToTodoModel(vm);
            todo.Id = _SessionRepository.getNextId(context, "id");
            List<Todo> todos = _SessionRepository.Get(context, "todos");
            todos.Add(todo);
            _SessionRepository.Set(context, todos, "todos");
        }
        public EditTodoVm FindById(int id , HttpContext context)
        {
            List<Todo> todos = _SessionRepository.Get(context, "todos");
            foreach(Todo todo in todos)
            {
                if(todo.Id == id)
                {
                    return _TodoMapper.MapTodoToEditTodoVm(todo);
                }
            }
            return null;
        }
        public void Update(int id , EditTodoVm vm , HttpContext context)
        {
            Todo todo = _TodoMapper.MapEditTodoVmToTodoModel(vm);
            List<Todo> todos = _SessionRepository.Get(context, "todos");
            for(int i = 0;i<todos.Count;i++)
            {
                if (todos[i].Id == id)
                {
                    todos[i] = todo;
                    break;
                }
            }
            _SessionRepository.Set(context, todos, "todos");
        }
        public void Delete(int id , HttpContext context)
        {
            List<Todo> todos = _SessionRepository.Get(context, "todos");
            List<Todo> newTodos = new List<Todo>();
            foreach (var todo in todos)
            {
                if(todo.Id != id)
                {
                    newTodos.Add(todo);
                }
            }
            _SessionRepository.Set(context, newTodos, "todos");
        }
    }

}
