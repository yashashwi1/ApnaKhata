using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKhata.DataModels
{
    public class User
    {
        public User()
        {
            this.Alerts = new List<Alert>();
            this.Expenses = new List<Expense>();
        }
       public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public string ProfileImage { get; set; }
        public string LastLogin { get; set; }

        public string LastUpdated { get; set; }

        public List<Alert> Alerts { get; set; }

        public List<Expense> Expenses { get; set; }

        public Expense MaxExpense
        {
            get {
                if (this.Expenses == null)
                {
                    return new Expense();
                }
                return this.Expenses.MaxBy(x => x.Amount);
            }
        }

        public int ExpenseAlertCount
        {
            get
            {
                if (this.Alerts == null)
                    return 0;
                return (this.Alerts.Where(c => c.Type == AlertType.Expense) != null) ? this.Alerts.Where(c => c.Type == AlertType.Expense).Count() : 0;
            }


        }
        public int DailyRemindersCount
        {
            get
            {
                if(this.Alerts == null)
                    return 0;
                return (this.Alerts.Where(c => c.Type == AlertType.Expense) != null) ? this.Alerts.Where(c => c.Type == AlertType.DailyReminders).Count() : 0;
            }
        }

        public int OccasionalRemindersCount
        {
            get
            {
                if (this.Alerts == null)
                    return 0;
                return (this.Alerts.Where(c => c.Type == AlertType.Expense) != null) ? this.Alerts.Where(c => c.Type == AlertType.OccasionalReminders).Count() : 0;
            }
        }

        public int OtherRemindersCount
        {
            get
            {
                if (this.Alerts == null)
                    return 0;
                return (this.Alerts.Where(c => c.Type == AlertType.Expense) != null) ? this.Alerts.Where(c => c.Type == AlertType.Others).Count() : 0;
            }
        }

        public string FrequencyOfExpense
        {
            get
            {
                if (this.Expenses == null)
                {
                    return "No Expenditure as yet.";
                }

                var timeDifference = new Double();
                var time = new DateTime();
                foreach (var item in this.Expenses)
                {                   
                    timeDifference = (time - item.ExpenseDate).TotalMilliseconds;
                    time = item.ExpenseDate;
                }

                var averageTime = timeDifference / this.Expenses.Count; // this is milliseconds
                TimeSpan t = TimeSpan.FromMilliseconds(averageTime);
                string answer = string.Format("{0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms",
                                        t.Hours,
                                        t.Minutes,
                                        t.Seconds,
                                        t.Milliseconds);
                return answer;
            }
        }
        // public List<Rep> Alerts { get; set; }
    }
}
