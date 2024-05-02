using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvioesLibrary.Models;
using Dapper;

namespace AvioesLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public ClienteModel CreateCliente(ClienteModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Avioes")))
            {
                var p = new DynamicParameters();
                p.Add("@nome", model.Nome);
                p.Add("@email", model.Email);
                p.Add("@telefone", model.Telefone);
                p.Add("@passaporte", model.Passaporte);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spClientes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }
        }
    }
}
