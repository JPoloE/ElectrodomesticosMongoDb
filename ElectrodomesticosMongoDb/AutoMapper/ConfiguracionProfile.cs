using AutoMapper;
using Dominio.Entitadas.Comandos;
using Dominio.Entitadas.Entidades;
using Infrastructura.CasosdeUso.EntidadesMongo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectrodomesticosMongoDb.AutoMapper
{
    public  class ConfiguracionProfile : Profile
    {
        public ConfiguracionProfile()
        {
            CreateMap<InsertarNuevoElectodomestico, Electrodomesticos>().ReverseMap();
            CreateMap<ElectrodomesticoEntidad, Electrodomesticos>().ReverseMap();
        }
    }
}
