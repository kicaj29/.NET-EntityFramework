using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticMigrations
{
    public class RunAutomaticMigrations
    {
        public void Run()
        {
            // By default it connects to (LocalDb)\MSSQLLocalDB
            using (var db = new CustomerContext())
            {
                db.Customers.Add(new Customer { Name = "Cust1 " });
                db.SaveChanges();

                foreach (var c in db.Customers)
                {
                    Console.WriteLine(c.Name);
                }
            }
        }
    }
}
