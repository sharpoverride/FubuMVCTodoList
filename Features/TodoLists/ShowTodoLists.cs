using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoListFubuMVC.Features.TodoLists
{
    public class ShowTodoLists
    {
        public ShowTodoListsOutput get_Index()
        {
            var model = new ShowTodoListsOutput();

            model.Items = new List<ListItem>()
            {
                new ListItem{ Text = "Backlog", Slug="backlog"},

                new ListItem{ Text = "Urgent", Slug="urgent"},
                new ListItem{ Text = "Ideas",  Slug="ideas"},
                new ListItem{ Text = "Future tasks",  Slug="future-tasks"}

            };


            return model;
        } 
    }
}