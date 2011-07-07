using FubuMVC.Core;
using FubuMVC.Spark;

using TodoListFubuMVC.Features.TodoLists;
using TodoListFubuMVC.Features.Todos;

namespace TodoListFubuMVC
{
    public class ConfigureFubuMVC : FubuRegistry
    {
        public ConfigureFubuMVC()
        {
            // This line turns on the basic diagnostics and request tracing
            IncludeDiagnostics(true);

            // All public methods from concrete classes ending in "Controller"
            // in this assembly are assumed to be action methods
            Actions.IncludeClassesSuffixedWithController()
                .IncludeType<ShowTodoLists>()
                .IncludeType<ShowTodo>();

            // Policies
            Routes
                .IgnoreControllerNamesEntirely()
                .IgnoreMethodSuffix("Html")
                .HomeIs<ShowTodoLists>(m=>m.get_Index())
                .RootAtAssemblyNamespace();

            this.UseSpark();
            // Match views to action methods by matching
            // on model type, view name, and namespace
            Views.TryToAttachWithDefaultConventions();
        }
    }
}