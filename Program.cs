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
    StockDate = new DateTime(2022, 10, 20),
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
    StockDate = new DateTime(2022, 10, 20),
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

decimal totalValue = 0.0M;
foreach (Product product in products)
{
    if (!product.Sold)
    {
        totalValue += product.Price;
    }
}
Console.WriteLine($"Total inventory value: ${totalValue}");

Console.WriteLine(greeting);

Console.WriteLine("Products:");
for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine($"{i + 1}. {products[i].Name}");
}
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
