using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Interfaces.Flujo
{
    public interface IPersonaFlujo
    {
        Task<IEnumerable<PersonaResponse>> Obtener();
        Task<PersonaResponse> Obtener(Guid Id);
        Task<Guid> Agregar(PersonaBase persona);
        Task<Guid> Editar(Guid Id, PersonaBase persona);
        Task<Guid> Eliminar(Guid Id);
    }
}
