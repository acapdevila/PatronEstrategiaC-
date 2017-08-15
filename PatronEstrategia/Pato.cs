using System;

namespace PatronEstrategia
{
    public abstract class Pato
    {
        private readonly IGraznar _estrategiaGraznar;
        private readonly IVolar _estrategiaVolar;

        protected Pato(IGraznar estrategiaGraznar, IVolar estrategiaVolar)
        {
            _estrategiaGraznar = estrategiaGraznar;
            _estrategiaVolar = estrategiaVolar;
        }

        public void Graznar()
        {
          _estrategiaGraznar.Graznar();
        }

        public void Volar()
        {
           _estrategiaVolar.Volar();
        }

        public void Nadar()
        {
            Console.WriteLine("Nadando");
        }


        public abstract void Mostrar();
    }

    

    public class PatoDomestico : Pato
    {
        public PatoDomestico() : 
            base(new GraznarComoUnPato(), new VolarConAlas())
        {
        }

        public override void Mostrar()
        {
            Console.WriteLine("Soy un pato doméstico");
        }
    }

    public class PatoPelirrojo : Pato
    {

        public PatoPelirrojo() :
               base(new GraznarComoUnPato(), new VolarConAlas())
        {
        }

        public override void Mostrar()
        {
            Console.WriteLine("Soy un pato pelirrojo");
        }
        
    }

    public class PatoDeJuguete : Pato
    {
        public PatoDeJuguete() : 
                base(new GraznarComoUnaBocina(), new NoVolar())
        {
        }


        public override void Mostrar()
        {
            Console.WriteLine("Soy un pato de juguete");
        }
    }

    public class PatoDecorativo : Pato
    {
        public PatoDecorativo() :
            base(new GraznarEnSilencio(), new NoVolar())
        {
        
        }


        public override void Mostrar()
        {
            Console.WriteLine("Soy un pato decorativo");
        }
    }
}
