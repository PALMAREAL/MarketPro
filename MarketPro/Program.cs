using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MarketPro
{
    class Program
    {
        
        static void Main(string[] args)
        {

            var market = new MarketService();

            market.Order(new User("George"), new Product("Bici"), 1);
            market.Order(new User("Lulu"), new Product("Folios"), 100);
            market.Order(new User("David"), new Product("Bolis"), 10);
            market.Order(new User("George"), new Product("Libreta"), 1);

            market.GetPull();
        }

    }
}



















//Queue<Order> ordersMarket = new Queue<Order>();

//ordersMarket.Enqueue(new Order(new Product("Bici"), 1));
//ordersMarket.Enqueue(new Order(new Product("Boli"), 5));
//ordersMarket.Enqueue(new Order(new Product("Bici"), 1));
//ordersMarket.Enqueue(new Order(new Product("Folios"), 10));


//IDictionary<User, Queue<Order>> My_dict =
//    new Dictionary<User, Queue<Order>>();

//Adding key/ value pairs in the Dictionary
// Using Add() method
//My_dict.Add(new KeyValuePair<User, Queue<Order>>(new User("George"), ordersMarket));
//My_dict.Add(new KeyValuePair<User, Queue<Order>>(new User("Lulu"), ordersMarket));

//My_dict.Add(new User("George"), ordersMarket);

//foreach (var element in My_dict)
//{
//    Console.WriteLine("User:- {0} Product:- {1}, Quantity:- {2}",
//        element.Key.Name, element.Value.Peek().Product.Name, element.Value.Peek().Quantity);

//}
//Console.ReadLine();
//foreach (KeyValuePair<User, Queue<Order>> element in My_dict)
//{
//    Console.WriteLine("User:- {0} Product:- {1}, Quantity:- {2}",
//        element.Key.Name, element.Value.Peek().Product.Name, element.Value.Peek().Quantity);
//    Console.ReadLine();
//}






//Queue<Order> ordersMarket = new Queue<Order>();

//ordersMarket.Enqueue(new Order(new User("George"), new Product("Bici"),1  ));
//ordersMarket.Enqueue(new Order(new User("Lulu"), new Product("Boli"), 5));
//ordersMarket.Enqueue(new Order(new User("George"), new Product("Bici"),1  ));
//ordersMarket.Enqueue(new Order(new User("David"), new Product("Folios"), 10));


//Pull("George");
//void Pull(string customerName)
//{

//foreach (var item in orders)
//{
//    if (item.UserName == customerName)
//    {
//        Console.WriteLine(
//            item.UserName + "  " +
//            item.ProductName + "  " +
//            item.Quantity);
//    }
//    else
//    {
//        Console.WriteLine("No match");
//    }
//}

//Console.ReadLine();
//}




//void Pull() // FUNCIONA
//{
//    foreach (var item in queueOrder)
//    {
//        Console.WriteLine(item.Customer.CustomerName + "  " + item.Product.ProductName + "  " + item.Quantity);
//    }
//    Console.ReadLine();
//}

//Console.WriteLine("Insert the Name");
//var customerName = Console.ReadLine();

//Console.WriteLine("Insert the Product");
//var productName = Console.ReadLine();

//Console.WriteLine("Insert the Quantity");
//var quantity = Console.ReadLine();

// EJEMPLO DE QUEUE
//var queue = new Queue<Product>();

//queue.Enqueue(new Product("Bicicleta"));
//queue.Enqueue(new Product("Cámara Fotos"));
//queue.Enqueue(new Product("Laptop"));
//queue.Enqueue(new Product("Móvil"));

//foreach (var item in queue)
//{
//    var listOfProducts = item.ProductName;
//    Console.WriteLine(listOfProducts);
//}

//Console.ReadLine();


// FUNCIONA
//var queueOrder = new Queue<Order>();

//queueOrder.Enqueue(new Order("Lulu", new Product("Moto"), 1));
//            queueOrder.Enqueue(new Order("David", new Product("Chupa Chups"), 7));
//            queueOrder.Enqueue(new Order("George", new Product("Bici"), 1));


//            Pull("George");

//void Pull(string customerName)
//{

//    foreach (var item in queueOrder)
//    {
//        if (item.CustomerName == customerName)
//        {
//            Console.WriteLine(
//                item.CustomerName + "  " +
//                item.Product.Name + "  " +
//                item.Quantity);
//        }
//    }
//    Console.ReadLine();

//}