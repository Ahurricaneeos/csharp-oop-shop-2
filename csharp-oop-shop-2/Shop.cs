using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_composizione
{
    public class Shop
    {
        // Attributes
        private string name;
        private string city;
        private string address;
        private int civic;
        private List<Product> products;

        // Costructor
        public Shop(string name, string city, string address, int civic)
        {
            this.name = name;
            this.city = city;
            this.address = address;
            this.civic = civic;
            this.products = new List<Product>();
        }

        // Getters

        public string GetName() { return name; }
        public string GetCity() { return city; }
        public string GetAddress() { return address; }
        public int GetCivic() { return civic; }
        public List<Product> GetListProducts() { return products; }

        // Setters

        public void SetCity(string city) { this.city = city; }
        public void SetAddress(string address) { this.address = address; }
        public void SetCivic(int civic) { this.civic = civic; }

        // Methods

        public void addProduct(Product newProduct)
        {
            products.Add(newProduct);
        }

        public void addListProducts(List<Product> newListProducts)
        {
            foreach (Product newListProduct in newListProducts) { products.Add(newListProduct); }
        }

        public string StringShopRappresent()
        {
            string rapprStr = "Nome negozio: " + this.name + "\n";
            rapprStr += "Città: " + this.city + "\n";
            rapprStr += "Indirizzo: " + this.address + " ";
            rapprStr += this.civic + "\n";
            rapprStr += "Prodotti disponibili: \n";

            foreach (Product scanProduct in products)
            {
                rapprStr += " - " + scanProduct.GetProductString() + "\n";
            }
            return rapprStr;
        }
    }
}