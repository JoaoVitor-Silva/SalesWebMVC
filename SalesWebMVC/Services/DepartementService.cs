using System.Collections.Generic;
using SalesWebMVC.Data;
using System.Linq;
using SalesWebMVC.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMVC.Services
{
    public class DepartementService
    {
        private readonly SalesWebMVCContext _context;

        public DepartementService(SalesWebMVCContext context)
        {
            _context = context;
        }
        
        public async Task<List<Departement>> FindAllAsync()
        {
            return await _context.Departement.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
