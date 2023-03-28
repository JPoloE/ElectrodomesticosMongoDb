using AutoMapper;
using Dominio.CasosdeUso.Gateway.Repositorio;
using Dominio.Entitadas.Entidades;
using Infrastructura.CasosdeUso.EntidadesMongo;
using Infrastructura.CasosdeUso.Interfaces;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructura.CasosdeUso.ElectrodomesticoRepositorio
{
    public class ElectrodomesticoRepositorio : IElectrodomesticoRepositorio
    {
        private readonly IMongoCollection<ElectrodomesticoEntidad> coleccion;
        private readonly IMapper _mapper;

        public ElectrodomesticoRepositorio(IContext context, IMapper mapper)
        {
            this.coleccion = context.Electrodomesticos;
            _mapper = mapper;
        }

        public Task<Electrodomesticos> DeleteElectrodomesticoByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Electrodomesticos>> GetAllElectrodomesticosAsync()
        {
            var electrodomesticos = await coleccion.FindAsync(Builders<ElectrodomesticoEntidad>.Filter.Empty);
            var listaElectrodomesticos = electrodomesticos.ToEnumerable().Select(electrodomestico => _mapper.Map<Electrodomesticos>(electrodomestico)).ToList();
            return listaElectrodomesticos;
        }

        public Task<Electrodomesticos> GetElectrodomesticoByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Electrodomesticos> InsertarElectrodomesticoAsync(Electrodomesticos electrodomesticos)
        {
            var electrodomesticoGuardar = _mapper.Map<ElectrodomesticoEntidad>(electrodomesticos);
            await coleccion.InsertOneAsync(electrodomesticoGuardar);
            return electrodomesticos;
        }

        public Task<Electrodomesticos> UpdateElectrodomesticoAsync(Electrodomesticos electrodomesticos)
        {
            throw new NotImplementedException();
        }
    }
}
