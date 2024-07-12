using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //product data
        string[] prodNames = {"Potatoes", "Trash bags", "Duct tape", "Hershey's chocolate", "Pencils", "Pop tarts"};
        int[] prodNumbers = {10000080, 10900080, 12000050, 16740080, 10048390, 12856500};
        double[] prices = {5.58, 6.7, 2.3, 1.10, 2.99, 3.35};
        int[] quantities = {2, 1, 3, 9, 5, 2};

        //create product list
        List<Product> products = new();

        //add product data to a Product list
        int i = 0;
        foreach(string name in prodNames)
        {
            products.Add(new Product(name, prodNumbers[i], prices[i], quantities[i]));
            i++;
        }


        //address data
        string[] streets = ["224 String Ave", "510 Program Road",];
        string[] towns = ["Calctown", "Linterville"];
        string[] states = ["Alabama", "Alberta"];
        string[] countries = ["USA", "Canada"];

        //create address list
        List<Address> addresses = new();

        //add product data to a Address list
        i = 0;
        foreach(string street in streets)
        {
            addresses.Add(new Address(street, towns[i], states[i], countries[i]));
            i++;
        }


        //customer names
        string[] custNames = {"Bob Hawks", "Anna Craig"};

        //create customer list
        List<Customer> customers = new();

        //add customer data to a Customer list
        i = 0;
        foreach(string name in custNames)
        {
            customers.Add(new Customer(name, addresses[i]));
            i++;
        }


        //create order list
        List<Order> orders = new();

        //add product and customer data to an Order list
        i = 0;
        int x = 0;
        foreach(Customer customer in customers)
        {
            orders.Add(new Order(customer));
            for(int j = 0; j < 3; j++)
            {
                orders[i].AddToCart(products[x]);
                x++;
            }
            i++;
        }


        //return packing label
        

        //return shipping label
        int shippingCost = 0;
        for(i = 0; i < 2; i++)
        {
            Console.WriteLine($"Order {i + 1}\n");
            Console.WriteLine(orders[i].GetPackingLabel());
            Console.WriteLine(orders[i].GetShippingLabel());
            if(customers[i].IsUSA())
            {
                shippingCost = 5;
            }
            else
            {
                shippingCost = 35;
            }
            Console.WriteLine($"Shipping Cost: ${shippingCost}");
            Console.WriteLine($"Total cost of order: ${Math.Round(orders[i].GetPrice(), 2)}");
            Console.WriteLine("\n");
        }

        //return total cost of the order

        //display these results
    }
}