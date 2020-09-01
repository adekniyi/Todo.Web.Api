using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoWebApi.Entities;

namespace TodoWebApi.services
{
    public interface ITodoInfoRepository
    {
        IEnumerable<Todo> GetTodos();


        Todo GetTodo(int id);

        bool cityExist(int id);

        void AddTodo(int id, Todo todo);

        bool save();

        void UpdatePointOfInterest(int id, Todo todo);

        void DeletePointOfInterest(Todo todo);
    }
}
