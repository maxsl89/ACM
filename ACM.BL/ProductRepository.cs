using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    class ProductRepository
    {
        /// <summary>
        /// Retrieve one product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            //Create the instance of the Product class 
            //Pass in the request id
            Product product = new Product(productId);

            //Code that retrieves the difined product 

            //Temporary hard coded values to return 
            // a populated product 

            if(productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size";
                product.CurrentPrice = 15.96M;

            }           
            return product;
        }       
    }
}
