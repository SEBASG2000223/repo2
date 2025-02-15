using Abstracciones.Interfaces.DA;
using Abstracciones.Interfaces.Flujo;
using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flujo
{
    public class PersonaFlujo : IPersonaFlujo
    {
        private IPersonaDA _personaDA;

        public PersonaFlujo(IPersonaDA personaDA)
        {
            _personaDA = personaDA;
        }

        public Task<Guid> Agregar(PersonaBase persona)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> Editar(Guid Id, PersonaBase persona)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> Eliminar(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PersonaResponse>> Obtener()
        {
            throw new NotImplementedException();
        }

        public Task<PersonaResponse> Obtener(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
