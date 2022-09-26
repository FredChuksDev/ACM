using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }
        public Product(int productId)
        {
        ProductId = productId;
        }
        private string _productName;
        public string ProductName
        {
            get
            {
               
                return _productName.InsertSpaces();
            } 
            set
            {
                _productName = value;
            }
        }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        public decimal? CurrentPrice { get; set; }

        

        public override string ToString() => ProductName;

        ////---Retrieves one product
        //public Product Retrieve(int productId)
        //{
        //    return new Product();
        //} 

        ////---Saves current product
        //public bool Save()
        //{
        //    return true;
        //}
        ////---Validates the product data
        public override bool Validate()
        {
            var isValid = true;
            if(string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if(CurrentPrice == null) isValid = false;

            return isValid;

        }

        public string Log()
        {
            throw new NotImplementedException();
        }
    }
}
