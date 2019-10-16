using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoApplication.Models;

namespace ToDoApplication.ViewModels
{
    public class Cart
    {
        public ToDo ToDo { get; set; }
        public int Quantity { get; set; }

        public Cart(ToDo ToDo, int quantity)
        {
            this.ToDo = ToDo;
            Quantity = quantity;
        }
    }
}