using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructura.CasosdeUso.EntidadesMongo
{
    public class ElectrodomesticoEntidad
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id_Mongo { get; set; }
        public string Nombre_Electrodomestico { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime Fecha_Creacion { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public decimal Precio { get; set; }
    }
}
