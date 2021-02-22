using System;
using System.Linq;
using EntityFrameworkIntroduction.Data;
using Microsoft.EntityFrameworkCore;


namespace EntityFrameworkIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SoftUniContext())
            {
                var towns = db.Towns
                    .Include(t => t.Addresses)
                    .ToList();

                foreach (var town in towns)
                {
                    Console.WriteLine(town.Name);
                    foreach (var address in town.Addresses)
                    {
                        Console.WriteLine($"---{address.AddressText}");
                    }
                }

               
            }
        }
    }
}
