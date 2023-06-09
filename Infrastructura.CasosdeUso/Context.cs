﻿using Infrastructura.CasosdeUso.EntidadesMongo;
using Infrastructura.CasosdeUso.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructura.CasosdeUso
{
    public class Context : IContext
    {
        private readonly IMongoDatabase _database;

        public Context(string stringConnection, string DBname)
        {
            MongoClient cliente = new MongoClient(stringConnection);
            _database = cliente.GetDatabase(DBname);
        }

        public IMongoCollection<ElectrodomesticoEntidad> Electrodomesticos => _database.GetCollection<ElectrodomesticoEntidad>("electrodomesticos");
    }
}
