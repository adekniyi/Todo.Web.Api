using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoWebApi.Models;

namespace TodoWebApi
{
    public class TodoDataStore
    {
        public static TodoDataStore Current { get; } = new TodoDataStore();
        public List<TodoDto> Todos { get; set; }

        public TodoDataStore()
        {
            Todos = new List<TodoDto>()
            {
                new TodoDto()
                {
                    id = 1,
                    todo = "do the laundry",
                    isCompleted = false
                },

                new TodoDto()
                {
                    id = 2,
                    todo = "read a novel",
                    isCompleted = false
                },
                new TodoDto()
                {
                    id = 3,
                    todo = "play game",
                    isCompleted = false
                },
                new TodoDto()
                {
                    id = 4,
                    todo = "visit a friend",
                    isCompleted = false
                },
                new TodoDto()
                {
                    id = 5,
                    todo = "write code",
                    isCompleted = false
                },
            };
        }
    }
}
