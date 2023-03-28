using Infrastructura.CasosdeUso.EntidadesMongo;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructura.CasosdeUso.Interfaces
{
    public interface IContext
    {
        public IMongoCollection<ElectrodomesticoEntidad> Electrodomesticos { get; }
    }
}
