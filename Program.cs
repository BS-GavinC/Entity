

using Entity;
using Entity.Models;

using (MyDbContext dc = new MyDbContext())
{

    Console.WriteLine(dc.shops.Where(x => x.Id == 1).FirstOrDefault().Email);


    /*dc.shops.Add(new Shop
    {
        Name = "La petite Lucette",
        Address = "Rue des pousettes",
        Email = "Lucette@poucette.hello"
    });

    dc.SaveChanges();*/
}
