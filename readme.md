FubuMVC TodoList
================

Very simplistic Todo list app. For a given todo list slug, it will keep in the browsers local cache any todo list item you want.

The UI was developed by the Spline MVC guy(s). And the code was adapted to work with Knockout-JS.

You define the Todo Lists you want to have displayed on the Home page in Code, I don't see the point in persisting to yet another database.

The default Todo Lists are:

- Backlog
- Urgent
- Ideas
- Future tasks

You can use any slug you want to act as a store for todo list items. <web-app-url>/items/any-slug_you_can_imagine-here

The items you add get persisted to the browsers localStorage, so unless you clear your browser's storage, you should have the items you add available.

Enjoy!


