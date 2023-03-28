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
using System.Net;
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

        public async Task<string> DeleteElectrodomesticoByIdAsync(string id)
        {
            var electrodomesticos = await coleccion.DeleteOneAsync(x => x.Id_Mongo == id);
            if (electrodomesticos.DeletedCount.Equals(1))
            {
                return $"Electrodomestico con Id_Mongo: {id} eliminado correctamente";
            }
            else
            {
                return $"Electrodomestico con Id_Mongo: {id} no encontrado";
            }
        }
    
    

        public async Task<List<Electrodomesticos>> GetAllElectrodomesticosAsync()
        {
            var electrodomesticos = await coleccion.FindAsync(Builders<ElectrodomesticoEntidad>.Filter.Empty);
            var listaElectrodomesticos = electrodomesticos.ToEnumerable().Select(electrodomestico => _mapper.Map<Electrodomesticos>(electrodomestico)).ToList();
            return listaElectrodomesticos;
        }

        public async Task<Electrodomesticos> GetElectrodomesticoByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Electrodomesticos> InsertarElectrodomesticoAsync(Electrodomesticos electrodomesticos)
        {
            var electrodomesticoGuardar = _mapper.Map<ElectrodomesticoEntidad>(electrodomesticos);
            await coleccion.InsertOneAsync(electrodomesticoGuardar);
            return electrodomesticos;
        }

        public async Task<Electrodomesticos> UpdateElectrodomesticoAsync(Electrodomesticos electrodomesticos)
        {
            var actualizarElectrodomestico = _mapper.Map<ElectrodomesticoEntidad>(electrodomesticos);
            var actualizaElectrodomestico = await coleccion.FindOneAndReplaceAsync(electrodomesticoEntidad => electrodomesticoEntidad.Id_Mongo 
            == electrodomesticos.Id_Mongo, actualizarElectrodomestico);
            return electrodomesticos;

        }
    }
}
