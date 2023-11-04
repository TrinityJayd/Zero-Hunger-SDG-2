using System.ComponentModel;

namespace Zero_Hunger_SDG_2.Models
{
    public class TotalsViewModel
    {
        [DisplayName("Total Income")]
        public decimal TotalIncome { get; set; }

        [DisplayName("Total Expenses")]
        public decimal TotalExpenses { get; set; }

        [DisplayName("Total Yield")]
        public int TotalYield { get; set; }
    }
}
