using ApnaKhata.DataModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaPOC.Shared
{
    public partial class MainLayout
    {
        [CascadingParameter]

        public User userData
        {
            get
            {
                return this._userData;
            }
            set
            {
                if (value != null)
                {
                    this._userData = value;
                }
            }
        }

        public User _userData { get; private set; }

        protected override void OnInitialized()
        {
            this._userData = userData;
            //RouteView
           // UriHelper.NavigateTo($"/{userData}");
        }
    }
}
