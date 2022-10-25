using System.Collections;

class Product
{
    public int Price { get; set; }
    public int ProductId { get; set; }
    public string ProductName { get; set; }
}
class CartItem
{
    public int CartId { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
}
class ShoppingCart
{

    List<CartItem> CartItems;
    public ShoppingCart()
    {
        this.CartItems = new List<CartItem>();
    }
    public void Add(CartItem cartItem)
    {
        CartItems.Add(cartItem);    
    }
    public void GetBalance()
    {
        foreach (CartItem cartItem in CartItems)
        { 
            Console.WriteLine(cartItem.Quantity * cartItem.Product.Price);
        }
    }
    public void GetList()
    {
        int TotalPrice = 0;
        foreach (CartItem cartItem in CartItems)
        {
            Console.WriteLine($"İsim : {cartItem.Product.ProductName,-10} \n" +
                            $"Adet : {cartItem.Quantity,-7} \n" +
                            $"Ürün Fiyat : {cartItem.Product.Price,-7} \n" +
                            $"Toplam Tutar : {cartItem.Quantity * cartItem.Product.Price} \n");
            TotalPrice += cartItem.Quantity * cartItem.Product.Price;
        }
        Console.WriteLine($"Toplam Sepet Tutar : {TotalPrice}");
    }
    public void Remove(int id)
    {
        CartItems.RemoveAt(id-1);
    }
}
class program
{
    public static void Main()
    {
        Product product1 = new Product()
        {
            Price = 5000,
            ProductId = 1,
            ProductName = "Laptop"
        };
        Product product2 = new Product()
        {
            Price = 2000,
            ProductId = 2,
            ProductName = "PC"
        };
        CartItem cartItem1 = new CartItem()
        {
            CartId = 1,
            Product = product1,
            Quantity = 5,
        };
        CartItem cartItem2 = new CartItem()
        {
            CartId = 2,
            Product = product2,
            Quantity = 7,
        };
        ShoppingCart shoppingCart = new ShoppingCart();
        shoppingCart.Add(cartItem1); 
        shoppingCart.Add(cartItem2);
        shoppingCart.GetList();
        shoppingCart.Remove(1);
        shoppingCart.GetList();
    }
}