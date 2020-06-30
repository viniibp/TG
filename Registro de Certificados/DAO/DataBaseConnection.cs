using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_Certificados.DAO
{
    public class DataBaseConnection
    {
        protected IMongoDatabase GetConnection()
        {
            var nomeBanco = "RH";

            var cliente = new MongoClient();

            IMongoDatabase db = cliente.GetDatabase(nomeBanco);
            return db;
        }
    }
}
