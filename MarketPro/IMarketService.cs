using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPro
{
    public interface IMarketService
    {
        void Order(User user, Product product, int quantity);
        string GetPull();
    }
}
