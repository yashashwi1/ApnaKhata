using ApnaKhata.DataModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaPOC.Pages
{
    public partial class Index
    {
        [CascadingParameter]
        [Parameter]
        public User userData { get; set; }

        protected override void OnInitialized()
        {

           // UriHelper.NavigateTo($"userHome/{userData}");
        }
    }
}
