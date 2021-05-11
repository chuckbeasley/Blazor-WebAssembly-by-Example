// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace KanbanBoard.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Packt\ch07\KanbanBoard\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Packt\ch07\KanbanBoard\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Packt\ch07\KanbanBoard\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Packt\ch07\KanbanBoard\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Packt\ch07\KanbanBoard\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Packt\ch07\KanbanBoard\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Packt\ch07\KanbanBoard\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Packt\ch07\KanbanBoard\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Packt\ch07\KanbanBoard\_Imports.razor"
using KanbanBoard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Packt\ch07\KanbanBoard\_Imports.razor"
using KanbanBoard.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Packt\ch07\KanbanBoard\Pages\Index.razor"
using KanbanBoard.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "E:\Packt\ch07\KanbanBoard\Pages\Index.razor"
       
    public TaskItem CurrentItem;
    List<TaskItem> TaskItems = new List<TaskItem>();

    public Dictionary<string, object> InputAttributes = new Dictionary<string, object>()
    {
        { "maxlength", "25" },
        { "placeholder", "enter new task" },
        { "title", "This textbox is used to enter your tasks." }
    };

    protected override void OnInitialized()
    {
        TaskItems.Add(new TaskItem
        {
            TaskName = "Call Mom",
            Priority = TaskPriority.High
        });
        TaskItems.Add(new TaskItem
        {
            TaskName = "Buy milk",
            Priority = TaskPriority.Medium
        });
        TaskItems.Add(new TaskItem
        {
            TaskName = "Exercise",
            Priority = TaskPriority.Low
        });
    }

    private void OnStartDrag(TaskItem item)
    {
        CurrentItem = item;
    }

    private void OnDrop(TaskPriority priority)
    {
        CurrentItem.Priority = priority;
    }

    private void AddTask(string taskName)
    {
        var taskItem = new TaskItem()
        {
            TaskName = taskName,
            Priority = TaskPriority.High
        };
        TaskItems.Add(taskItem);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591