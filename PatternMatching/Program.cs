using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void ProcessProduct(BaseProduct p)
        {
            //Before C# 7
            var x = p as KitchenProduct;
            if (x != null)
            {
                //we can access to KitchenProduct spesific properties and methods etc..
            }

            //C# 7.0
            if (p is KitchenProduct k)
            {
                //p is converted to KitchenProduct and you can use k variable in order to access KitchenProduct spesific properties and methods etc..
            }


            //Type switch 
            switch (p)
            {
                case KitchenProduct kp:
                    break;
                case ElectronicProduct ep:
                    break;
                //null switch
                case null:
                    throw new ArgumentNullException(nameof(p));
            }
        }
    }

    class BaseProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class ElectronicProduct : BaseProduct
    {
    }

    class KitchenProduct : BaseProduct
    {
    }
}


