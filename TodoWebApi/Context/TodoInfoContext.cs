using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoWebApi.Entities;

namespace TodoWebApi.Context
{
    public class TodoInfoContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        public TodoInfoContext(DbContextOptions<TodoInfoContext> options)
          : base(options)
        {


            //Database.EnsureCreated();

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>()
                .HasData(new Todo()
                {
                    id = 1,
                    todo = "do the laundry",
                    isCompleted = false
                },

                new Todo()
                {
                    id = 2,
                    todo = "read a novel",
                    isCompleted = false
                },
                new Todo()
                {
                    id = 3,
                    todo = "play game",
                    isCompleted = false
                },
                new Todo()
                {
                    id = 4,
                    todo = "visit a friend",
                    isCompleted = false
                },
                new Todo()
                {
                    id = 5,
                    todo = "write code",
                    isCompleted = false
                });


            base.OnModelCreating(modelBuilder);
        }
    }
}
