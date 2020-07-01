using MongoDB.Bson;
using MongoDB.Driver;
using Registro_de_Certificados.model;
using Registro_de_Certificados.utility;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Registro_de_Certificados.DAO.modelDAO
{
    public class ColaboradorDAO : DataBaseConnection
    {
        private IMongoCollection<Colaborador> collection;

        public ColaboradorDAO()
        {
            collection = GetConnection().GetCollection<Colaborador>("Funcionario");
        }

        private bool ConnectionOk()
        {
            bool isMongoLive = collection.Database.RunCommandAsync((Command<BsonDocument>)"{ping:1}").Wait(2000);
            return isMongoLive;
        }

        public Colaborador Entrar(Usuario usuario)
        {
            if (!ConnectionOk()) return null;
            try
            {
                var md5 = new MD5Hash();

                var funcionario = collection.Find(
                    func =>
                        usuario.Username == func.Username &&
                        md5.GetMd5Hash(usuario.Senha).Equals(func.Senha)
                ).SingleOrDefault();

                return funcionario;
            }
            catch (Exception) {
                return new Colaborador();
            }
            
        }

        public void InsertFuncionario(Colaborador funcionario)
        {
            collection.InsertOne(funcionario);
        }

        public void AtualizarFuncionario(Colaborador funcionario)
        {
            collection.ReplaceOne(f => f.Id == funcionario.Id, funcionario);
        }

        public List<Colaborador> AllFuncionarios() => collection.Find(_ => true).ToList();

        public int Ranking(ObjectId id) => AllFuncionarios().OrderBy(f => f.GerenciadorCursos().Pontuacao()).ToList().FindIndex(c => c.Id == id);

        //public void DeleteFuncionario(Funcionario funcionario)
        //{
        //    collection.DeleteOne(f => f.Id == funcionario.Id);
        //}

    }
}
