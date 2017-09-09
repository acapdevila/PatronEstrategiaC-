namespace PatronEstrategia
{
    public class ValidadorPeticiones
    {
        public bool Validar(Peticion peticion)
        {
            switch (peticion.TipoPeticion)
            {
                case TipoPeticion.FormaDePago:
                    return ValidarFormaDePago(peticion);

                case TipoPeticion.OrdenDeCobro:
                    return ValidarOrdenDeCobro(peticion);

                default:
                    return false;
            }
        }


        private bool ValidarOrdenDeCobro(Peticion peticion)
        {
            /**/

            return true;
        }

        private bool ValidarFormaDePago(Peticion peticion)
        {
            /**/

            return true;
        }

        /* Un método de validación por cada tipo de petición */
    }

    public class Peticion
    {
        public TipoPeticion TipoPeticion { get; set; }
    }

    public enum TipoPeticion
    {
        FormaDePago,
        OrdenDeCobro
    }
}
