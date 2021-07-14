#r "D:\WMs\workspacer\0.9.10\workspacer.Shared.dll"
#r "D:\WMs\workspacer\0.9.10\plugins\workspacer.Bar\workspacer.Bar.dll"
#r "D:\WMs\workspacer\0.9.10\plugins\workspacer.ActionMenu\workspacer.ActionMenu.dll"
#r "D:\WMs\workspacer\0.9.10\plugins\workspacer.FocusIndicator\workspacer.FocusIndicator.dll"

using System;
using workspacer;
using workspacer.Bar;
using workspacer.ActionMenu;
using workspacer.FocusIndicator;

Action<IConfigContext> doConfig = (context) =>
{
    // Uncomment to switch update branch (or to disable updates)
    //context.Branch = Branch.None

    context.AddBar();
    context.AddFocusIndicator();
    var actionMenu = context.AddActionMenu();

    context.WorkspaceContainer.CreateWorkspaces("one", "two", "three", "four", "five");
};
return doConfig;