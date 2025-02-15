﻿using Abstracciones.Interfaces.DA;
using Abstracciones.Modelos;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA
{
    public class MarcaDA : IMarcaDA
    {
        private IRepositorioDapper _repositorioDapper;
        private SqlConnection _sqlConnection;


        public MarcaDA(IRepositorioDapper repositorioDapper)
        {
            _repositorioDapper = repositorioDapper;
            _sqlConnection = _repositorioDapper.ObtenerRepostorio();
        }

        public async Task<IEnumerable<MarcaResponse>> Obtener()
        {
            string query = @"ObtenerMarcas";
            var resultadoConsulta = await _sqlConnection.QueryAsync<MarcaResponse>(query);
            return resultadoConsulta;
        }

        public async Task<MarcaResponse> Obtener(Guid Id)
        {
            string query = @"ObtenerMarca";
            var resultadoConsulta = await _sqlConnection.QueryAsync<MarcaResponse>(query, new { Id = Id });
            return resultadoConsulta.FirstOrDefault();
        }
    }
}
