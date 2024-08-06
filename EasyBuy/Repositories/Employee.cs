using EasyBuy.Repositories.Interfaces;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;


namespace EasyBuy.Repositories
{
    public class Employee : IEmployee
    {       
        public Employee GetEmployeeAsync(string userId, string password)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionClass.ConnectionString("EasyBuyDatabase")))
            {
                var employee = connection.Query<Employee>("dbo.GetEmployee @UserName,@Password", new { UserName = userId, Password= password }).FirstOrDefault();
                return employee;
            }
        }
    }
}
