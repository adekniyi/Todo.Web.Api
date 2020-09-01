using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoWebApi.Context;
using TodoWebApi.Entities;

namespace TodoWebApi.services
{
    public class TodoInfoRepository : ITodoInfoRepository
    {
        private readonly TodoInfoContext _context;

        public TodoInfoRepository(TodoInfoContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));

        }
        public void AddTodo(int id, Todo todo)
        {
            var newTodo = GetTodo(id);

            _context.Todos.Add(newTodo);
        }

        public bool cityExist(int id)
        {
            return _context.Todos.Any(c => c.id == id); 
        }

        public void DeletePointOfInterest(Todo todo)
        {
            _context.Remove(todo);
        }

        public IEnumerable<Todo> GetTodos()
        {
            return _context.Todos.ToList();
        }

        public Todo GetTodo(int id)
        {
            return _context.Todos.Where(c => c.id == id).FirstOrDefault();
        }

        public bool save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdatePointOfInterest(int cityid, Todo todo)
        {
            
        }
    }
}
