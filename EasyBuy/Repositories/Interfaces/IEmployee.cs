using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuy.Repositories.Interfaces
{
    public interface IEmployee
    {
        Employee GetEmployeeAsync(string userId, string password);
    }
}
