using DevExpress.Mvvm;
using System.Collections.Generic;

namespace CustomizeDocumentViewerToolbarExample
{
    public class Product
    {
        public string ProductName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
    public class ViewModel : ViewModelBase
    {

        public ViewModel()
        {
            List<Product> products = new List<Product> {
                new Product() { ProductName = "Chang", Country = "UK", City = "Cowes", UnitPrice = 19, Quantity = 10 },
                new Product() { ProductName = "Gravad lax", Country = "Italy", City = "Reggio Emilia", UnitPrice = 12.5, Quantity = 16 },
                new Product() { ProductName = "Ravioli Angelo", Country = "Brazil", City = "Rio de Janeiro", UnitPrice = 19, Quantity = 12 },
                new Product() { ProductName = "Tarte au sucre", Country = "Germany", City = "Leipzig", UnitPrice = 22, Quantity = 50 },
                new Product() { ProductName = "Steeleye Stout", Country = "USA", City = "Denver", UnitPrice = 18, Quantity = 20 },
                new Product() { ProductName = "Pavlova", Country = "Austria", City = "Graz", UnitPrice = 21, Quantity = 52 },
                new Product() { ProductName = "Longlife Tofu", Country = "USA", City = "Boise", UnitPrice = 7.75, Quantity = 120 },
                new Product() { ProductName = "Alice Mutton", Country = "Mexico", City = "México D.F.", UnitPrice = 21, Quantity = 15 },
                new Product() { ProductName = "Alice Mutton", Country = "Canada", City = "Tsawwassen", UnitPrice = 44, Quantity = 16 },
                new Product() { ProductName = "Chang", Country = "UK", City = "Cowes", UnitPrice = 19, Quantity = 10 },
                new Product() { ProductName = "Gravad lax", Country = "Italy", City = "Reggio Emilia", UnitPrice = 12.5, Quantity = 16 },
                new Product() { ProductName = "Ravioli Angelo", Country = "Brazil", City = "Rio de Janeiro", UnitPrice = 19, Quantity = 12 },
                new Product() { ProductName = "Tarte au sucre", Country = "Germany", City = "Leipzig", UnitPrice = 22, Quantity = 50 },
                new Product() { ProductName = "Steeleye Stout", Country = "USA", City = "Denver", UnitPrice = 18, Quantity = 20 },
                new Product() { ProductName = "Pavlova", Country = "Austria", City = "Graz", UnitPrice = 21, Quantity = 52 },
                new Product() { ProductName = "Longlife Tofu", Country = "USA", City = "Boise", UnitPrice = 7.75, Quantity = 120 },
                new Product() { ProductName = "Alice Mutton", Country = "Mexico", City = "México D.F.", UnitPrice = 21, Quantity = 15 },
                new Product() { ProductName = "Alice Mutton", Country = "Canada", City = "Tsawwassen", UnitPrice = 44, Quantity = 16 },
                new Product() { ProductName = "Chang", Country = "UK", City = "Cowes", UnitPrice = 19, Quantity = 10 },
                new Product() { ProductName = "Gravad lax", Country = "Italy", City = "Reggio Emilia", UnitPrice = 12.5, Quantity = 16 },
                new Product() { ProductName = "Ravioli Angelo", Country = "Brazil", City = "Rio de Janeiro", UnitPrice = 19, Quantity = 12 },
                new Product() { ProductName = "Tarte au sucre", Country = "Germany", City = "Leipzig", UnitPrice = 22, Quantity = 50 },
                new Product() { ProductName = "Steeleye Stout", Country = "USA", City = "Denver", UnitPrice = 18, Quantity = 20 },
                new Product() { ProductName = "Pavlova", Country = "Austria", City = "Graz", UnitPrice = 21, Quantity = 52 },
                new Product() { ProductName = "Longlife Tofu", Country = "USA", City = "Boise", UnitPrice = 7.75, Quantity = 120 },
                new Product() { ProductName = "Alice Mutton", Country = "Mexico", City = "México D.F.", UnitPrice = 21, Quantity = 15 },
                new Product() { ProductName = "Alice Mutton", Country = "Canada", City = "Tsawwassen", UnitPrice = 44, Quantity = 16 },
                new Product() { ProductName = "Chang", Country = "UK", City = "Cowes", UnitPrice = 19, Quantity = 10 },
                new Product() { ProductName = "Gravad lax", Country = "Italy", City = "Reggio Emilia", UnitPrice = 12.5, Quantity = 16 },
                new Product() { ProductName = "Ravioli Angelo", Country = "Brazil", City = "Rio de Janeiro", UnitPrice = 19, Quantity = 12 },
                new Product() { ProductName = "Tarte au sucre", Country = "Germany", City = "Leipzig", UnitPrice = 22, Quantity = 50 },
                new Product() { ProductName = "Steeleye Stout", Country = "USA", City = "Denver", UnitPrice = 18, Quantity = 20 },
                new Product() { ProductName = "Pavlova", Country = "Austria", City = "Graz", UnitPrice = 21, Quantity = 52 },
                new Product() { ProductName = "Longlife Tofu", Country = "USA", City = "Boise", UnitPrice = 7.75, Quantity = 120 },
                new Product() { ProductName = "Alice Mutton", Country = "Mexico", City = "México D.F.", UnitPrice = 21, Quantity = 15 },
                new Product() { ProductName = "Alice Mutton", Country = "Canada", City = "Tsawwassen", UnitPrice = 44, Quantity = 16 }
            };
            Products = products;
        }
        public List<Product> Products { get; }
    }
}
