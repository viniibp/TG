using System;
using MongoDB.Bson;
using Registro_de_Certificados.DAO.modelDAO;

namespace Registro_de_Certificados.model
{
    public class Usuario
    {
        [MongoDB.Bson.Serialization.Attributes.BsonId]
        public ObjectId Id { get; set; }
        public string Username { get; set; }
        public string Senha { get; set; }

        public Colaborador Entrar()
        {
            return new FuncionarioDAO().Entrar(this);
        }
    }
}