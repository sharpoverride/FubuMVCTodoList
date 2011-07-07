using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TodoListFubuMVC.Features.TodoLists;

namespace TodoListFubuMVC.Features.Todos
{
    public class ShowTodo
    {
        public TodoItem get_Items_Slug(ListItem item)
        {
            var model = new TodoItem();

            model.Title = "Your Todo Items";
            model.DocumentId = "todos_"+item.Slug;

            return model;
        }
    }
}