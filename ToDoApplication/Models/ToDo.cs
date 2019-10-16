using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoApplication.Models
{
    public class ToDo
    {
        public int ID { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; } //odwołanie do 

        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime Date { get; set; }
        public bool IsDone { get; set; }
    }
}