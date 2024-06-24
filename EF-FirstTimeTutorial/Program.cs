using Microsoft.EntityFrameworkCore;

namespace EF_FirstTimeTutorial;

internal class Program
{
    static void Main(string[] args)
    {
        var context = new AppDbContext();

        //var users = context.Users.ToList();           //instance of users
        //var vendors = context.Vendors.ToList();       //instance of vendors 
     //   var products = context.Products.Include(v => v.Vendor).ToList();        //"Include" would basically only pull 1 instance of the vendor when the result is given, as opposed to showing it on every line if you create an instance yourslef to reference. This is done automatically by EF when Include is called.
     //   var requests = context.Requests.Include(u => u.User).ToList();
        var requestLines = context.RequestLines.Include(rl => rl.Request).Include(rl => rl.Product).ToList();   //creates the instances 

        
     /*   foreach(var user in users)
        {
            Console.WriteLine($"{user.Firstname}.{user.Lastname}");
        }

        vendors.ForEach(v => Console.WriteLine($"{v.Name}")); // does the same the thing as the "users foreach loop", just simplified.    */
     //   products.ForEach(p => Console.WriteLine($"{p.Name} | {p.Vendor!.Name}"));
     //   requests.ForEach(r => Console.WriteLine($"{r.Description} | {r.User!.Username}"));
        requestLines.ForEach(rl => Console.WriteLine($"{rl.Request!.Description} | {rl.Product!.Name} | {rl.Quantity} | {rl.Product!.Price:C} | {rl.Product!.Price * rl.Quantity}"));

    var total = context.RequestLines.Include(rl => rl.Product).Sum(rl => rl.Quantity * rl.Product!.Price);
    Console.WriteLine($"Total: {total:C}");
    }
}
