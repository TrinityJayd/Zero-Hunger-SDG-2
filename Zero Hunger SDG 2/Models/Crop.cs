using System;
using System.Collections.Generic;

namespace Zero_Hunger_SDG_2.Models
{
    public partial class Crop
    {
        public int CropId { get; set; }
        public string CropName { get; set; } = null!;
        public int CropYield { get; set; }
        public decimal CropExpenses { get; set; }
        public decimal CropIncome { get; set; }
    }
}
