using CorePro___Full_Stack_Assignment.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Data;
using System.Data.SqlClient;


namespace CorePro___Full_Stack_Assignment.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class productsController : ControllerBase
    {

        private readonly ILogger<productsController> _logger;
        private readonly IConfiguration _configuration;

        public productsController(ILogger<productsController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet]
        public ArrayList GetProduct()
        {
            ArrayList result = new ArrayList();

            string query = @"Select Name from dbo.Product";
            DataTable table = new DataTable();
            string connectionSting = _configuration.GetConnectionString("ProductAppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(connectionSting))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    foreach (DataRow dr in table.Rows)
                    {
                        result.Add(Convert.ToString(dr["product"]));
                    }

                    myReader.Close();
                    myCon.Close();

                }
                return result;
                    
            }
        }

        [HttpPost]

        public string AddProduct(Product p)
        {
            
            return "d";
        }
    }
}
