using Abstracciones.Modelos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Interfaces.API
{
    public interface IPersonaController
    {
        Task<IActionResult> Obtener();
        Task<IActionResult> Obtener(Guid Id);
        Task<IActionResult> Agregar(PersonaBase persona);
        Task<IActionResult> Editar(Guid Id, PersonaBase persona);
        Task<IActionResult> Eliminar(Guid Id);
    }
}
