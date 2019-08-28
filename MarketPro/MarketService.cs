using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using MarketPro;

namespace MarketPro
{
    public class MarketService: IMarketService
    {

        private IDictionary<User, Queue<Order>> _marketDict = new Dictionary<User, Queue<Order>>();


        public void Order(User user, Product product, int quantity)
        {
            var queueOrders = new Queue<Order>();
            queueOrders.Enqueue(new Order(new Product(product.Name), quantity));

            _marketDict.Add(new User(user.Name), queueOrders);

        }



        public string GetPull()
        {
            var result = "";

            foreach (KeyValuePair<User, Queue<Order>> element in _marketDict)
            {
                result = string.Format("User: {0} / Product: {1}, / Quantity: {2}", 
                    element.Key.Name, 
                    element.Value.Peek().Product.Name, 
                    element.Value.Peek().Quantity);
                Console.WriteLine(result);
            }
            
            Console.ReadLine();
            return result;
        }
    }
}
