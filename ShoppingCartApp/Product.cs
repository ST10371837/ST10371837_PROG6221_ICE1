using ShoppingCartApp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShoppingCartApp
{
    // Enum defining product categories
    public enum ProductCategory
    {
        Clothing, Electronics, Home, Beauty, Groceries
    }

    // Base class for all products
    public class Product
    {
        // Fields
        private string name;
        private double price;
        private ProductCategory category;

        // Properties
        public string Name { get { return name; } }
        public double Price { get { return price; } }
        public ProductCategory Category { get { return category; } }

        // Constructor
        public Product(string name, double price, ProductCategory category)
        {
            this.name = name;
            this.price = price;
            this.category = category;
        }

        // Method to get information about the product
        public virtual void GetInfo()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}, Category: {Category}");
        }
    }

    // Derived class for clothing products
    public class ClothingProduct : Product
    {
        // Fields
        private string size;
        private string color;

        // Properties
        public string Size { get { return size; } }
        public string Color { get { return color; } }

        // Constructor
        public ClothingProduct(string name, double price, ProductCategory category, string size, string color)
            : base(name, price, category)
        {
            this.size = size;
            this.color = color;
        }

        // Method to get information about the clothing product
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Size: {Size}, Color: {Color}");
        }
    }

    // Derived class for electronics products
    public class ElectronicsProduct : Product
    {
        // Fields
        private string brand;
        private string model;

        // Properties
        public string Brand { get { return brand; } }
        public string Model { get { return model; } }

        // Constructor
        public ElectronicsProduct(string name, double price, ProductCategory category, string brand, string model)
            : base(name, price, category)
        {
            this.brand = brand;
            this.model = model;
        }

        // Method to get information about the electronics product
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Brand: {Brand}, Model: {Model}");
        }
    }
}