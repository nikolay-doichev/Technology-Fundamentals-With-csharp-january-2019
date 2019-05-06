using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            var buyerList = new Dictionary<string, double[]>();

            while (command != "buy")
            {
                var array = command.Split(' ').ToArray();
                string product = array[0];
                double productPrice = double.Parse(array[1]);
                int productQuantity = int.Parse(array[2]);

                //Beer 2.40 350
                //Water 1.25 200
                //IceTea 5.20 100
                //Beer 1.20 200
                //IceTea 0.50 120
                //buy

                if (!buyerList.ContainsKey(product))
                {
                    buyerList.Add(product, new double[2]);                    

                }
                buyerList[product][0] = productPrice;
                buyerList[product][1] += productQuantity;
                
                command = Console.ReadLine();
            }
            foreach (var item in buyerList)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0]*item.Value[1]:f2}");            
            }

            
        }
       
    }
}
