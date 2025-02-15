using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Modelos
{
    public class ModeloBase
    {
        public string Nombre { get; set; }



    }
    public class ModeloResponse : ModeloBase
    {
        public Guid Id { get; set; }

        public string Marca { get; set; }



    }
}

