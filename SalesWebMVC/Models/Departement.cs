using System;
using System.Linq;
using System.Collections.Generic;
namespace SalesWebMVC.Models
{
    public class Departement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Departement()
        {
        }

        public Departement(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSaller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime Initial, DateTime Final)
        {
            return Sellers.Sum(seller => seller.TotalSales(Initial, Final));
        }
    }
}
