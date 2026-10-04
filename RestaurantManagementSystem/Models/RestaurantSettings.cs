using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Models
{
    public static class RestaurantSettings
    {
        public static decimal TaxRate { get; set; } = 0.14m;
        public static decimal ServiceChargeRate { get; set; } = 0.1m;

        public static decimal CalculateTax(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException("Amount cannot be empty.");
            return amount * TaxRate;
        }
        
        public static decimal CalculateServiceCharge(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException("Amount cannot be empty.");
            return amount * ServiceChargeRate;
        }


    }
}
