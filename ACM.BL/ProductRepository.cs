using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        //Retrieve one product
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);
            if(productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted size of 4 bright Yellow mini sunflowers";
                product.CurrentPrice = 15.96M;
            }
            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");
            return product;



        }
        //Save the current product

        public bool Save(Product product)
        {
            var success = true;
            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        //Call an insert stored proceedure
                    }
                    else
                    {
                        //Call an Update stored proceedure
                    }
                }
                else
                {
                    success = false;
                }
                return success;
            }




            //Code that saves the passed in product
            return true;
        }


    }
}
