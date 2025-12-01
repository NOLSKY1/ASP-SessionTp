using sessionTpDIP.Models;
using sessionTpDIP.ViewModels;
using System.Text.Json;
namespace sessionTpDIP.Persisters
{
    public class SessionRepository
    {
        
        public List<Todo> Get(HttpContext context , string key) {
            string json = context.Session.GetString(key);
            if (String.IsNullOrEmpty(json)){
                return new List<Todo>();
            }
            return JsonSerializer.Deserialize<List<Todo>>(json);
        }
        public void Set(HttpContext context , List<Todo> todos , string key)
        {
            string json  = JsonSerializer.Serialize(todos);
            context.Session.SetString(key , json);
        }
        public int  getNextId(HttpContext context , string key)
        {
            int ? oldId = context.Session.GetInt32(key);
            int nextId = (oldId ?? 0) + 1;
            context.Session.SetInt32(key, nextId);
            return nextId;
        }
        public void SetUsername(string key, HttpContext context ,User user )
        {
            context.Session.SetString(key, user.Username );
        }
        
        
    }
}
