using System;

namespace PatronEstrategia
{
    public abstract class Pato
    {
        public virtual void Graznar()
        {
            Console.WriteLine("¡Cuac, cuac!");
        }

        public void Nadar()
        {
            Console.WriteLine("Nadando");
        }

        public void Volar()
        {
            Console.WriteLine("Volando");
        }


        public abstract void Mostrar();
    }

    public class PatoDomestico : Pato
    {
        public override void Mostrar()
        {
            Console.WriteLine("Soy un pato doméstico");
        }
    }

    public class PatoPelirrojo : Pato
    {
        public override void Mostrar()
        {
            Console.WriteLine("Soy un pato pelirrojo");
        }
    }

    public class PatoDeJuguete : Pato
    {
        public override void Graznar()
        {
            Console.WriteLine("¡Meec, meec!");
        }


        public override void Mostrar()
        {
            Console.WriteLine("Soy un pato de juguete");
        }
    }
}
