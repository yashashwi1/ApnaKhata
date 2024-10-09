using Microsoft.VisualBasic;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKhata.DataModels
{

    public class Expense
	{

   
        public string UserId { get; set; }

     
        public string ExpenseId { get; set; }

     
        public string Name { get; set; }

        public string Type { get; set; }


        public Double Amount { get; set; }

   
        public DateTime ExpenseDate { get; set; }


	}
}
