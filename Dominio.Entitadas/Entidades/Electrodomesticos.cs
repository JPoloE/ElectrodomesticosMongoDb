using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entitadas.Entidades
{
    public class Electrodomesticos
    {
        public int Id { get; set; }
        public string Nombre_Electrodomestico { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime Fecha_Creacion { get; set;}
        public DateTime Fecha_Ingreso { get; set;}
        public decimal Precio { get; set;}
    }
}
