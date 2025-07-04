using RetailInventory.Data;
using RetailInventory.Models;
using Microsoft.EntityFrameworkCore;

using var context = new AppDbContext();

//LAB7
var filtered = await context.Products
    .Where(p => p.Price > 1000)
    .OrderByDescending(p => p.Price)
    .ToListAsync();

Console.WriteLine("Filtered and Sorted Products:");
foreach (var p in filtered)
    Console.WriteLine($"{p.Name} - ₹{p.Price}");

var productDTOs = await context.Products
    .Select(p => new { p.Name, p.Price })
    .ToListAsync();

Console.WriteLine("\nProjected DTOs:");
foreach (var dto in productDTOs)
    Console.WriteLine($"{dto.Name} - ₹{dto.Price}");


//LAB 6
// 1. Update a Product (Laptop)
// var product = await context.Products.FirstOrDefaultAsync(p => p.Name == "Laptop");
// if (product != null)
// {
//     product.Price = 70000;
//     await context.SaveChangesAsync();
//     Console.WriteLine("Product updated: Laptop price changed to ₹70000");
// }
// else
// {
//     Console.WriteLine("Laptop not found.");
// }

// 2. Delete a Product (Rice Bag)
// var toDelete = await context.Products.FirstOrDefaultAsync(p => p.Name == "Rice Bag");
// if (toDelete != null)
// {
//     context.Products.Remove(toDelete);
//     await context.SaveChangesAsync();
//     Console.WriteLine("Product deleted: Rice Bag");
// }
// else
// {
//     Console.WriteLine("Rice Bag not found.");
// }

//LAB 5
// 1. Retrieve All Products
// var products = await context.Products.ToListAsync();
// foreach (var p in products)
//     Console.WriteLine($"{p.Name} - ₹{p.Price}");

// 2. Find by ID
// var product = await context.Products.FindAsync(1);
// Console.WriteLine($"Found: {product?.Name}");

// 3. FirstOrDefault with Condition
// var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
// Console.WriteLine($"Expensive: {expensive?.Name}");

//LAB 4
// var electronics = new Category { Name = "Electronics" };
// var groceries = new Category { Name = "Groceries" };

// await context.Categories.AddRangeAsync(electronics, groceries);

// var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
// var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };

// await context.Products.AddRangeAsync(product1, product2);
// await context.SaveChangesAsync();

// Console.WriteLine("Data inserted successfully.");



// context.Database.EnsureCreated();

// var category = new Category { Name = "Electronics" };
// context.Categories.Add(category);
// context.SaveChanges();

// var product = new Product { Name = "Laptop", Price = 1000, CategoryId = category.Id };
// context.Products.Add(product);
// context.SaveChanges();

// var products = context.Products.Include(p => p.Category).ToList();
// foreach (var p in products)
// {
//     Console.WriteLine($"{p.Name} - {p.Price} - Category: {p.Category.Name}");
// }
