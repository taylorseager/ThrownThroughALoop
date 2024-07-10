// See https://aka.ms/new-console-template for more information
List<Product> products = new List<Product>()
{
  new Product()
  {
    Name = "Football",
    Price = 15,
    Sold = false,
    StockDate = new DateTime(2022, 10, 20),
    ManufactureYear = 2010
  },
   new Product()
  {
    Name = "Hockey Stick",
    Price = 25,
    Sold = false,
    StockDate = new DateTime(2022, 10, 20),
    ManufactureYear = 2010
  },
   new Product()
  {
    Name = "Boomerang",
    Price = 5,
    Sold = true,
    StockDate = new DateTime(2022, 10, 20),
    ManufactureYear = 2010
  },
   new Product()
  {
    Name = "Frisbee",
    Price = 7,
    Sold = false,
    StockDate = new DateTime(2022, 10, 20),
    ManufactureYear = 2010
  },
    new Product()
  {
    Name = "Golf Putter",
    Price = 17,
    Sold = false,
    StockDate = new DateTime(2022, 10, 20),
    ManufactureYear = 2010
  },
     new Product()
  {
    Name = "Hockey helmet",
    Price = 50,
    Sold = false,
    StockDate = new DateTime(2022, 10, 20),
    ManufactureYear = 2010
  },
   new Product()
  {
    Name = "Soccer ball",
    Price = 9,
    Sold = true,
    StockDate = new DateTime(2022, 10, 20),
    ManufactureYear = 2010
  },
   new Product()
  {
    Name = "Baseball bat",
    Price = 12,
    Sold = false,
    StockDate = new DateTime(2022, 10, 20),
    ManufactureYear = 2010
  },
    new Product()
  {
    Name = "Softball",
    Price = 7,
    Sold = false,
    StockDate = new DateTime(2022, 10, 20),
    ManufactureYear = 2010
  }
};

string greeting = @"Welcome to Thrown For a Loop
Your one-stop shop for used sporting equipment";

Console.WriteLine(greeting);

Console.WriteLine("Products:");
for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine($"{i + 1}. {products[i].Name}");
}
Console.WriteLine("Please enter a product number: ");

int response = int.Parse(Console.ReadLine().Trim());

while (response > products.Count || response < 1)
{
    Console.WriteLine("Choose a number between 1 and 5!");
    response = int.Parse(Console.ReadLine().Trim());
}

Product chosenProduct = products[response - 1];
Console.WriteLine($"You chose: {chosenProduct.Name}, which costs {chosenProduct.Price} dollars and is {(chosenProduct.Sold ? "" : "not ")}sold.");
