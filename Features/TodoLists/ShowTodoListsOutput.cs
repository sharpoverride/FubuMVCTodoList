using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoListFubuMVC.Features.TodoLists
{
    public class ShowTodoListsOutput
    {
        public List<ListItem> Items { get; set; }
    }

    public class ListItem
    {
        public string Text { get; set; }
        public string Url { get; set; }
        public string Slug { get; set; }
    }
}