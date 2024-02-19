using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    internal class ToDoDTO
    {
        public string Name { get; set; }
        public bool Completed { get; set; }
        public int EstimatedHours { get; set; }
        public int CategoryId { get; set; }
    }

    internal class ToDo
    {
        //return a list of the dtos that are not completed
        public List<ToDoDTO> GetTodos()
        {
            return null;
        }

        //return a list of the names of the dtos that are not completed
        public List<string> GetTodoNames()
        {
            return null;
        }

        //return the dto with the shortest Estimated Hours
        public ToDoDTO GetEasiest()
        {
            return null;
        }

        private List<ToDoDTO> _todos = new() {
            new (){
                Name= "Clean Windows",
                Completed = true,
                EstimatedHours = 5,
                CategoryId = 1
            },
            new (){
                Name= "Vacume",
                Completed= false,
                EstimatedHours= 3,
                CategoryId= 1
            },
            new (){
                Name= "Dust",
                Completed= false,
                EstimatedHours= 1,
                CategoryId= 1
            },
            new (){
                Name= "Grocery Shopping",
                Completed= false,
                EstimatedHours= 1,
                CategoryId= 2
            }
        };
    }
}
