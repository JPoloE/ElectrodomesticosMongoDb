using AutoMapper;
using Dominio.CasosdeUso.Gateway;
using Dominio.Entitadas.Comandos;
using Dominio.Entitadas.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace ElectrodomesticosMongoDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectrodomesticoController : ControllerBase
    {
        private readonly IElectrodomesticoCasodeUso _electrodomesticoCasodeUso;
        private readonly IMapper _mapper;

        public ElectrodomesticoController(IElectrodomesticoCasodeUso electrodomesticoCasodeUso, IMapper mapper)
        {
            _electrodomesticoCasodeUso = electrodomesticoCasodeUso;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<Electrodomesticos>> Obtener_Lista_Electrodomesticos()
        {
            return await _electrodomesticoCasodeUso.ObtenerListaElectrodomesticos();
        }

        [HttpPost]
        public async Task<Electrodomesticos> Guardar_Electrodomestico(InsertarNuevoElectodomestico electodomestico)
        {
            return await _electrodomesticoCasodeUso.AgregarElectrodomestico(_mapper.Map<Electrodomesticos>(electodomestico));
        }
    }
}