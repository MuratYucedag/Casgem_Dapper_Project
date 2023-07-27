using Casgem_Dapper_Project.DAL.Entitites;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Casgem_Dapper_Project.Controllers
{
    public class HeadingController : Controller
    {
        private readonly string _connectionString = "Server=DESKTOP-R7AR1ND;initial Catalog=CasgemDbDapper;integrated Security=true";

        public async Task<IActionResult> Index()
        {
            await using var connection = new SqlConnection(_connectionString);
            var values =await connection.QueryAsync<Headings>("Select * From TblHeading");
            return View(values);
        }
    }
}
