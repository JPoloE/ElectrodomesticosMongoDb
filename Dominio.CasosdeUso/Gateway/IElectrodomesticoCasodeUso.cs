using Dominio.Entitadas.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.CasosdeUso.Gateway
{
    public interface IElectrodomesticoCasodeUso
    {
        Task<Electrodomesticos> AgregarElectrodomestico(Electrodomesticos electrodomesticos);

        Task<List<Electrodomesticos>> ObtenerListaElectrodomesticos();

        Task<Electrodomesticos> ObtenerElectrodomesticoPorId(int id);
        
        Task<string> EliminarElectrodomesticoPorId(string id);

        Task<Electrodomesticos> EditarElectrodomestico(Electrodomesticos electrodomesticos);
    }
}
