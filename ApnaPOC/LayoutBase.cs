using ApnaKhata.DataModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaPOC
{
    public class LayoutBase : LayoutComponentBase
    {
        //public User UserData { get; set; }

        protected override void OnParametersSet()
        {
            // pull out the "Slug" parameter from the route data
            object slug = null;
            if ((this.Body.Target as RouteView)?.RouteData.RouteValues?.TryGetValue("userData", out slug) == true)
            {
               // UserData = slug as User;
            }
        }
    }
}
