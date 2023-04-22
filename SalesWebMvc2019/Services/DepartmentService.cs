using SalesWebMvc2019.Models;
using SalesWebMvc2019.Models.SalesWebMvc;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc2019.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvc2019Context _context;

        public DepartmentService(SalesWebMvc2019Context context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();

        }
    }
}
