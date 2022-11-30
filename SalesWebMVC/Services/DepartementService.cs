using System.Collections.Generic;
using SalesWebMVC.Data;
using System.Linq;
using SalesWebMVC.Models;

namespace SalesWebMVC.Services
{
    public class DepartementService
    {
        private readonly SalesWebMVCContext _context;

        public DepartementService(SalesWebMVCContext context)
        {
            _context = context;
        }
        
        public List<Departement> FindAll()
        {
            return _context.Departement.OrderBy(x => x.Name).ToList();
        }
    }
}
