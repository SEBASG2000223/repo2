using Abstracciones.Interfaces.Reglas;
using Abstracciones.Interfaces.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reglas
{
    public class RegistroReglas : IRegistroReglas
    {
        private readonly IRegistroServicio _registroServicios;
        private readonly IConfiguracion _configuracion;

        public RegistroReglas(IRegistroServicio registroServicios, IConfiguracion configuracion)
        {
            _registroServicios = registroServicios;
            _configuracion = configuracion;
        }

        public async Task<bool> VehiculoEstaRegistrado(string placa, string email)
        {
            var resultadoRegistro = await _registroServicios.Obtener(placa);

            return (resultadoRegistro != null && resultadoRegistro.Email == email);
        }
    }
}
