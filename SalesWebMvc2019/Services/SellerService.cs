using SalesWebMvc2019.Models;
using SalesWebMvc2019.Models.SalesWebMvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc2019.Services
{
    public class SellerService
    {
        private readonly SalesWebMvc2019Context _context;

        public SellerService(SalesWebMvc2019Context context)
        {
            _context = context;
        }

        public List<Seller> Findall()
        {
            return _context.Seller.ToList();

        }

        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }


    }
}
