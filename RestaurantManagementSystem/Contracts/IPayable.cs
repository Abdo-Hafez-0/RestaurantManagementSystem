using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Contracts
{
    public interface IPayable
    {
        void ProcessPayment(decimal amount);
    }
}
