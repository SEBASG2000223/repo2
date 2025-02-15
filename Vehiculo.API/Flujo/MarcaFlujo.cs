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
    public class MarcaFlujo : IMarcaFlujo
    {
        private readonly IMarcaDA _marcaDA;

        public MarcaFlujo(IMarcaDA marcaDA)
        {
            _marcaDA = marcaDA;
        }

        public async Task<IEnumerable<MarcaResponse>> Obtener()
        {
            return await _marcaDA.Obtener();
        }

        public async Task<MarcaResponse> Obtener(Guid Id)
        {
            return await _marcaDA.Obtener(Id);
        }
    }
}
