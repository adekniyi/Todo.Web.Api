using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TodoWebApi.Models;
using TodoWebApi.services;

namespace TodoWebApi.Controllers
{
    [ApiController]
    [Route("api/todos")]
    public class TodoController : ControllerBase
    {

        private readonly ITodoInfoRepository _todoInfoRepository;
        private readonly IMapper _mapper;


        public TodoController(ITodoInfoRepository todoInfoRepository, IMapper mapper)
        {
            _todoInfoRepository = todoInfoRepository ?? throw new ArgumentNullException(nameof(todoInfoRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public IActionResult GetTodos()
        {
            //return Ok(TodoDataStore.Current.Todos);

            //return new JsonResult(
            //        new List<object>()
            //        {
            //            new{id =1 , todo = "play guitar"},
            //             new{id =2 , todo = "eat dinner"},
            //        }
            //        );

           var todosEntities = _todoInfoRepository.GetTodos();

            return Ok(_mapper.Map<IEnumerable<TodoDto>>(todosEntities));
        }

        [HttpGet("{id}", Name = "GetTodo")]
        public IActionResult GetTodo(int id)
        {
            //var TodoResult = TodoDataStore.Current.Todos.FirstOrDefault(c => c.id == id);

            //if (TodoResult == null)
            //{
            //    return NotFound();
            //}

            //return Ok(TodoResult);


            var todo = _todoInfoRepository.GetTodo(id);

            if(todo == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<TodoDto>(todo));
        }


        [HttpPost]
        public IActionResult CreateTodo([FromBody] TodoForCreationDto todo)
        {
            //var TodoResult = TodoDataStore.Current.Todos.FirstOrDefault(c => c.id == id);

            //if (TodoResult == null)
            //{
            //    return NotFound();
            //}

            //var maxId = TodoDataStore.Current.Todos.Max(c => c.id);

            //var finalResult = new TodoDto()
            //{

            //    id = ++maxId,
            //    todo = todo.todo,
            //    isCompleted = todo.isCompleted

            //};


            //TodoDataStore.Current.Todos.Add(finalResult);

            //return CreatedAtRoute("GetTodo",
            //   new { id = finalResult.id }, finalResult);




            var finalResult = _mapper.Map<Entities.Todo>(todo);

            _todoInfoRepository.AddTodo(finalResult);

            _todoInfoRepository.save();

            var createdPointOfInterestToReturn = _mapper.Map<TodoDto>(finalResult);


            return CreatedAtRoute("GetTodo",
                new { id = createdPointOfInterestToReturn.id }, createdPointOfInterestToReturn);
        }

        [HttpPut("{id}")]

        public IActionResult UpdateTodo(int id , TodoForUpdatimgDto todo)
        {

            //var TodoResult = TodoDataStore.Current.Todos.FirstOrDefault(t => t.id == id);

            //if (TodoResult == null)
            //{
            //    return NotFound();
            //}


            //TodoResult.todo = todo.todo;
            //TodoResult.isCompleted = todo.isCompleted;


            //return NoContent();


            var TodoResult = _todoInfoRepository.GetTodo(id);

            if (TodoResult == null)
            {
                return NotFound();
            }



            _mapper.Map(todo, TodoResult);


            _todoInfoRepository.UpdateTodo(id,TodoResult);

            _todoInfoRepository.save();

            return NoContent();

        }

        [HttpDelete("{id}")]

        public IActionResult DeleteTodo(int id)
        {

            //var TodoResult = TodoDataStore.Current.Todos.FirstOrDefault(t => t.id == id);

            //if (TodoResult == null)
            //{
            //    return NotFound();
            //}


            var TodoResult = _todoInfoRepository.GetTodo(id);

            if (TodoResult == null)
            {
                return NotFound();
            }


            //TodoDataStore.Current.Todos.Remove(TodoResult);

            //return NoContent();


            _todoInfoRepository.DeleteTodo(TodoResult);

            _todoInfoRepository.save();

            return NoContent();
        }
    }
}
