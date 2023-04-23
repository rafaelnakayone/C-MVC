using SalesWebMvc2019.Models;
using SalesWebMvc2019.Models.SalesWebMvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc2019.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvc2019Context _context;

        public DepartmentService(SalesWebMvc2019Context context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync() /*Quando a aplicação é sincrona, quando vai acessar dados, disco ou rede, a operação fica muito lenta.
                                                       * Para isso utilizamos a aplicação assincrona para ficar mais rápido*/
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();

        }
    }
}
