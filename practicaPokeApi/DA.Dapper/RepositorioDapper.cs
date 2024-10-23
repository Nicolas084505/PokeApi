using Abstracciones.Interfaces.DA;
using Microsoft.Data.SqlClient;
using Abstracciones.Interfaces.DA;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;

namespace DA.Dapper
{
    public class RepositorioDapper: IRepositorioDapper
    {
        private readonly IConfiguration _configuration;
        private readonly SqlConnection _Conexion;

        public RepositorioDapper(IConfiguration configuration)
        {
            _configuration = configuration;
            _Conexion = new SqlConnection(_configuration.GetConnectionString("BD"));
        }

        public SqlConnection ObtenerRepositorio()
        {
            return _Conexion;
        }
    }
}
