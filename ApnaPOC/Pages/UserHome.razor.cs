using ApnaKhata.DataModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaPOC.Pages
{
    public partial class UserHome
    {
        
        [Parameter]
        public User userData { get; set; }
        protected override async Task OnInitializedAsync()
        {
            if (userData == null)
            {
                throw new Exception("Invalid User");
            }
        }
    }
}
