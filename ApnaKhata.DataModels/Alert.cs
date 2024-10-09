
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKhata.DataModels
{

    public class Alert
	{
        public string UserId { get; set; }

        public string AlertId { get; set; }

        public string Name { get; set; }

        public AlertType Type { get; set; }

        public string Message { get;set; }

        public string Condition { get; set; }


    }
}
