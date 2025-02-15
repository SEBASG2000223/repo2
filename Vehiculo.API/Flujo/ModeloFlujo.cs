using Abstracciones.Interfaces.DA;
using Abstracciones.Interfaces.Flujo;
using Abstracciones.Modelos;
using DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flujo
{
    public class ModeloFlujo : IModeloFlujo
    {
        private readonly IModeloDA _modeloDA;

        public ModeloFlujo(IModeloDA modeloDA)
        {
            _modeloDA = modeloDA;
        }

        public async Task<IEnumerable<ModeloResponse>> Obtener()
        {
            return await _modeloDA.Obtener();
        }

        public async Task<ModeloResponse> Obtener(Guid Id)
        {
            return await _modeloDA.Obtener(Id);
        }
    }
}
