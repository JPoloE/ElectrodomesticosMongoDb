using Dominio.Entitadas.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.CasosdeUso.Gateway.Repositorio
{
    public interface IElectrodomesticoRepositorio
    {
        Task<Electrodomesticos> InsertarElectrodomesticoAsync(Electrodomesticos electrodomesticos);

        Task<List<Electrodomesticos>> GetAllElectrodomesticosAsync();

        Task<Electrodomesticos> GetElectrodomesticoByIdAsync(int id);
       
        Task<Electrodomesticos> DeleteElectrodomesticoByIdAsync(int id);
       
        Task<Electrodomesticos> UpdateElectrodomesticoAsync(Electrodomesticos electrodomesticos);
    }
}
