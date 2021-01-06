using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        public Product()
        {
                
        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        // nullable type (number or a null) (needs to destingwish beetwen null (not set) and 0)
        public decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }

      
        /// <summary>
        /// Validates the product data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;
            //if (string.IsNullOrWhiteSpace(productName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
