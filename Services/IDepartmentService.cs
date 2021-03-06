using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PAS.Models;

namespace PAS.Services
{
    public interface IDepartmentService
    {
         Task<IEnumerable<Department>> GetAll();
         Task<Department> GetById(int id);
    }
}