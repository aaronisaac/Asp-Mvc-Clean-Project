using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Razor;

public class ViewLocationExpander : IViewLocationExpander
{
    public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
    {
        return new List<string> {"/Features/{1}/Views/{0}.cshtml", "/Features/Shared/Views/{0}.cshtml"};
    }

    public void PopulateValues(ViewLocationExpanderContext context)
    {
        
    }
}