
using ApnaKhata.DataModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaPOC.Shared
{
	public partial class NavMenu
	{
        private bool collapseNavMenu = true;

        [Parameter]
        public User userData { get; set; }
        private string home = "home";

        private string profile = "profile";

        private string expense = "expense";

        private string alerts = "alerts";

        private string reports = "reports";
        private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        private void onNavLinkClick(string linkName)
        {
            var route = string.Empty;
            switch (linkName)
            {
                case "home":
                    {
                        route = $"/";
                        break;

                    }
                case "profile":
                    {
                        route = $"/";
                        break;
                    }

                case "expense":
                {
                    route = $"/";
                    break;

                }
                case "alerts":
                    {
                        route = $"/";
                        break;

                    }
                case "reports":
                    {
                        route = $"/";
                        break;

                    }
                default: {
                        route = $"/";
                        break;
                    }
            }

            UriHelper.NavigateTo(route);
        }
        private void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }
    }
}
