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

        public BagagemModel CreateBagagem(BagagemModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Avioes")))
            {
                var p = new DynamicParameters();
                p.Add("@peso", model.Peso);
                p.Add("@cump", model.Cump);
                p.Add("@larg", model.Larg);
                p.Add("@alt", model.Alt);
                p.Add("@bagtag", model.Bagtag);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spBagagens_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }
        }

        public VooModel CreateVoo(VooModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Avioes")))
            {
                var p = new DynamicParameters();
                p.Add("@numVoo", model.NumVoo);
                p.Add("@origem", model.Origem);
                p.Add("@destino", model.Destino);
                p.Add("@dataPartida", model.DataPartida);
                p.Add("@dataChegada", model.DataChegada);
                p.Add("@lugaresDisponiveis", model.LugaresDisponiveis);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spVoos_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }
        }

        public List<BagagemModel> GetBagagem_All()
        {
            List<BagagemModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Avioes")))
            {
                output = connection.Query<BagagemModel>("dbo.spBagagem_GetAll").ToList();
            }

            return output;
        }
    }
}
