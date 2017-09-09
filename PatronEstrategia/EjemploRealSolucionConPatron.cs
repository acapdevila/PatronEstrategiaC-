using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronEstrategia
{
    public class ValidadorPeticionesConPatronEstrategia
    {
        private readonly IEstrategiaValidacion _estrategiValidacion;

        public ValidadorPeticionesConPatronEstrategia(IEstrategiaValidacion estrategiValidacion)
        {
            _estrategiValidacion = estrategiValidacion;
        }

        public bool Validar(Peticion peticion)
        {
            return _estrategiValidacion.Validar(peticion);
        }
    }

    public interface IEstrategiaValidacion
    {
        bool Validar(Peticion peticion);
    }

}
