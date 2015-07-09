using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MyRESTService
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int ProductId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Categoryname { get; set; }

        [DataMember]
        public int Price { get; set; }
    }

    public partial class Products
    {
        private Products()
        {
            
        }

        private static readonly Products _instance = new Products();
        public static Products Instance { get { return _instance; } }

        private List<Product> products = new List<Product>
        {
            new Product{ProductId = 1, Name = "Product 1", Categoryname = "Category 1", Price = 10},
            new Product{ProductId = 2, Name = "Product 2", Categoryname = "Category 2", Price = 15},
            new Product{ProductId = 3, Name = "Product 3", Categoryname = "Category 3", Price = 20},
            new Product{ProductId = 4, Name = "Product 4", Categoryname = "Category 4", Price = 25},
        };

        public List<Product> PrductList { get {return products;} }
    }
}