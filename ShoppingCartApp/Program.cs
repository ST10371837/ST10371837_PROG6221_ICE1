
// Entry point for the console application
using ShoppingCartApp;

public class Program
{
    // Main method
    static void Main(string[] args)
    {
        // Example usage
        ShoppingCart cart = new ShoppingCart(5);

        // Adding products to the cart
        ClothingProduct shirt = new ClothingProduct("T-Shirt", 15.99, ProductCategory.Clothing, "M", "Blue");
        ElectronicsProduct phone = new ElectronicsProduct("Smartphone", 399.99, ProductCategory.Electronics, "Samsung", "Galaxy S20");

        cart.AddProduct(shirt);
        cart.AddProduct(phone);

        // Displaying products in the cart
        Console.WriteLine("Products in the shopping cart:");
        foreach (Product product in cart.Products)
        {
            if (product != null)
            {
                product.GetInfo();
            }
        }

        // Removing a product from the cart
        cart.RemoveProduct(shirt);

        Console.WriteLine("\nProducts in the shopping cart after removing a product:");
        foreach (Product product in cart.Products)
        {
            if (product != null)
            {
                product.GetInfo();
            }
        }
    }
}
