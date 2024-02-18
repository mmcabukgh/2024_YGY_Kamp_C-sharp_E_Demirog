// See https://aka.ms/new-console-template for more information


List<Category> categories = new List<Category>
{
    new Category {CategoryId = 1, CategoryName = "Bilgisayar"},
    new Category {CategoryId = 2, CategoryName = "Telefon"},
 };

List<Product> products = new List<Product>
{
    new Product{ProductId=1, CategoryId=1, ProductName="Acer Laptop", QuantityPerUnit="32 GB Ram", UnitPrice=10000, UnitsInStock=5 },
    new Product{ProductId=2, CategoryId=1, ProductName="Asus Laptop", QuantityPerUnit="16 GB Ram", UnitPrice=8000, UnitsInStock=3 },
    new Product{ProductId=3, CategoryId=1, ProductName="HP Laptop", QuantityPerUnit="8 GB Ram", UnitPrice=6000, UnitsInStock=2 },
    new Product{ProductId=4, CategoryId=2, ProductName="Samsung Telefon", QuantityPerUnit="4 GB Ram", UnitPrice=5000, UnitsInStock=15 },
    new Product{ProductId=5, CategoryId=2, ProductName="Apple Telefon", QuantityPerUnit="4 GB Ram", UnitPrice=8000, UnitsInStock=0 },


};

Console.WriteLine("Algoritmik -----------------------------------");

foreach (var product in products)
{
    if (product.UnitPrice > 5000 && product.UnitsInStock > 3) 
    {        
    Console.WriteLine("Ürün Listesi : " + product.ProductName);
    }
}
// GetProducts() Metodu ile
List<Product> gettedProducts = new List<Product>();
gettedProducts = GetProducts(products);

foreach (var product in gettedProducts)
{
        Console.WriteLine("GetProducts Ürün Listesi : " + product.ProductName);
}


Console.WriteLine("\n\nLinq -----------------------------------");

var results = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 1);
foreach (var product in results)
{
        Console.WriteLine("Ürün Listesi : " + product.ProductName);
}
// GetProductsLinq() Metodu ile
List<Product> gettedProductsLinq = new List<Product>();
gettedProductsLinq = GetProductsLinq(products);

foreach (var product in gettedProductsLinq)
{
        Console.WriteLine("GetProductsLinq Ürün Listesi : " + product.ProductName);
}

//Algoritmik -----------------------------------;
static List<Product> GetProducts(List<Product> products)
{
    List<Product> filteredProducts = new List<Product>();

    foreach (var product in products)
    {
        if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
        {
            filteredProducts.Add(product);
        }
    }
    return filteredProducts;
}

//Linq İle -----------------------------------;
static List<Product> GetProductsLinq(List<Product> products)
{   
    return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 1).ToList();
}



class Product
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public string QuantityPerUnit { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
}

class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}