using ApnaKhata.DataModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ApnaPOC
{
    public partial class Main
    {
        [Parameter]
        public User userData { get; set; }

        protected override void OnInitialized()
        {
            //RouteView
            
            //UriHelper.NavigateTo($"/{userData}");
        }
    }

}
