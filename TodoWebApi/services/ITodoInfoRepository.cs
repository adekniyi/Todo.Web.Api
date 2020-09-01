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

        void AddTodo(Todo todo);

        bool save();

        void UpdateTodo(int id, Todo todo);

        void DeleteTodo(Todo todo);
    }
}
