// See https://aka.ms/new-console-template for more information
List<Product> products = new List<Product>()
{
  new Product()
  {
    Name = "Football",
    Price = 13.95M,
    Sold = false,
    StockDate = new DateTime(2022, 10, 20),
    ManufactureYear = 2010,
    Condition = 4.2
  },
   new Product()
  {
    Name = "Hockey Stick",
    Price = 25.99M,
    Sold = false,
    StockDate = new DateTime(2022, 10, 20),
    ManufactureYear = 2010,
    Condition = 3.9
  },
   new Product()
  {
    Name = "Boomerang",
    Price = 5.50M,
    Sold = true,
    StockDate = new DateTime(2022, 10, 20),
    ManufactureYear = 2010,
    Condition = 4.1
  },
   new Product()
  {
    Name = "Frisbee",
    Price = 7.99M,
    Sold = false,
    StockDate = new DateTime(2022, 10, 20),
    ManufactureYear = 2010,
    Condition = 3.9
  },
    new Product()
  {
    Name = "Golf Putter",
    Price = 17.45M,
    Sold = false,
    StockDate = new DateTime(2022, 10, 20),
    ManufactureYear = 2010,
    Condition = 3.7
  },
     new Product()
  {
    Name = "Hockey helmet",
    Price = 49.99M,
    Sold = false,
    StockDate = new DateTime(2024, 07, 02),
    ManufactureYear = 2010,
    Condition = 4.8
  },
   new Product()
  {
    Name = "Soccer ball",
    Price = 9.87M,
    Sold = true,
    StockDate = new DateTime(2022, 10, 20),
    ManufactureYear = 2010,
    Condition = 4.5
  },
   new Product()
  {
    Name = "Baseball bat",
    Price = 12.13M,
    Sold = false,
    StockDate = new DateTime(2024, 06, 20),
    ManufactureYear = 2010,
    Condition = 3.2
  },
    new Product()
  {
    Name = "Softball",
    Price = 7.00M,
    Sold = false,
    StockDate = new DateTime(2022, 10, 20),
    ManufactureYear = 2010,
    Condition = 4.0
  }
};

string greeting = @"Welcome to Thrown For a Loop
Your one-stop shop for used sporting equipment";
string choice = null;
while (choice != "0")
{
    Console.WriteLine(@"Choose an option:
                        0. Exit
                        1. View All Products
                        2. View Product Details
                        3. View Latest Products");
    choice = Console.ReadLine();
    if (choice == "0")
    {
        Console.WriteLine("Goodbye!");
    }
    else if (choice == "1")
    {
        ListProducts();
    }
    else if (choice == "2")
    {
        ViewProductDetails();
    }
    else if (choice == "3")
    {
        ViewLatestProducts();
    }
};


void ViewProductDetails()
{
    ListProducts(); 

Product chosenProduct = null;

while (chosenProduct == null)
{
    Console.WriteLine("Please enter a product number: ");
    try
{
    int response = int.Parse(Console.ReadLine().Trim());
    chosenProduct = products[response - 1];
}
    catch (FormatException)
{
    Console.WriteLine("Please type only integers!");
}
    catch (ArgumentOutOfRangeException)
{
    Console.WriteLine("Please choose an existing item only!");
}
    catch (Exception ex)
{
    Console.WriteLine(ex);
    Console.WriteLine("Do Better!");
}
}

DateTime now = DateTime.Now;

TimeSpan timeInStock = now - chosenProduct.StockDate;
Console.WriteLine(@$"You chose: 
{chosenProduct.Name}, which costs {chosenProduct.Price} dollars.
It is {now.Year - chosenProduct.ManufactureYear} years old. 
It {(chosenProduct.Sold ? "is not available." : $"has been in stock for {timeInStock.Days} days.")}");
}

void ListProducts()
{
    decimal totalValue = 0.0M;
    foreach (Product product in products)
    {
        if (!product.Sold)
        {
            totalValue += product.Price;
        }
    }
    Console.WriteLine($"Total inventory value: ${totalValue}");
    Console.WriteLine("Products:");
    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {products[i].Name}");
    }
}

void ViewLatestProducts()
{
    // create a new empty List to store the latest products
    List<Product> latestProducts = new List<Product>();
    // Calculate a DateTime 90 days in the past
    DateTime threeMonthsAgo = DateTime.Now - TimeSpan.FromDays(90);
    //loop through the products
    foreach (Product product in products)
    {
        //Add a product to latestProducts if it fits the criteria
        if (product.StockDate > threeMonthsAgo && !product.Sold)
        {
            latestProducts.Add(product);
        }
    }
    // print out the latest products to the console 
    for (int i = 0; i < latestProducts.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {latestProducts[i].Name}");
    }
}
