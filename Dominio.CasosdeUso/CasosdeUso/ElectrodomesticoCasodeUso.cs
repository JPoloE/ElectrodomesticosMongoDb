using Dominio.CasosdeUso.Gateway;
using Dominio.CasosdeUso.Gateway.Repositorio;
using Dominio.Entitadas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.CasosdeUso.CasosdeUso
{
    public class ElectrodomesticoCasodeUso : IElectrodomesticoCasodeUso
    {

        private readonly IElectrodomesticoRepositorio _electrodomesticoRepositorio; 

        public ElectrodomesticoCasodeUso(IElectrodomesticoRepositorio electrodomesticoRepositorio)
        {
            _electrodomesticoRepositorio = electrodomesticoRepositorio;
        }

        public async Task<Electrodomesticos> AgregarElectrodomestico(Electrodomesticos electrodomesticos)
        {
            return await _electrodomesticoRepositorio.InsertarElectrodomesticoAsync(electrodomesticos);
        }

        public async Task<Electrodomesticos> EditarElectrodomestico(Electrodomesticos electrodomesticos)
        {
            return await _electrodomesticoRepositorio.UpdateElectrodomesticoAsync(electrodomesticos);
        }

        public async Task<Electrodomesticos> EliminarElectrodomesticoPorId(int id)
        {
            return await _electrodomesticoRepositorio.DeleteElectrodomesticoByIdAsync(id);
        }

        public async Task<Electrodomesticos> ObtenerElectrodomesticoPorId(int id)
        {
            return await _electrodomesticoRepositorio.GetElectrodomesticoByIdAsync(id);
        }

        public async Task<List<Electrodomesticos>> ObtenerListaElectrodomesticos()
        {
            return await _electrodomesticoRepositorio.GetAllElectrodomesticosAsync();
        }
    }
}
