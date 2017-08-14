using System;

namespace PatronEstrategia
{
    //public abstract class Pato
    //{
    //    public virtual void Graznar()
    //    {
    //        Console.WriteLine("¡Cuac, cuac!");
    //    }

    //    public void Nadar()
    //    {
    //        Console.WriteLine("Nadando");
    //    }

    //    public virtual void Volar()
    //    {
    //        Console.WriteLine("Volando");
    //    }


    //    public abstract void Mostrar();
    //}


    public abstract class Pato
    {

        public void Nadar()
        {
            Console.WriteLine("Nadando");
        }

      

        public abstract void Mostrar();
    }


    public class PatoDomestico : Pato, IVolar, IGraznar
    {
        public override void Mostrar()
        {
            Console.WriteLine("Soy un pato doméstico");
        }

        public virtual void Graznar()
        {
            Console.WriteLine("¡Cuac, cuac!");
        }
        public virtual void Volar()
        {
            Console.WriteLine("Volando");
        }

    }

    public class PatoPelirrojo : Pato, IVolar, IGraznar
    {
        public override void Mostrar()
        {
            Console.WriteLine("Soy un pato pelirrojo");
        }

        public virtual void Graznar()
        {
            Console.WriteLine("¡Cuac, cuac!");
        }
        public virtual void Volar()
        {
            Console.WriteLine("Volando");
        }

    }

    public class PatoDeJuguete : Pato, IGraznar
    {
        public void Graznar()
        {
            Console.WriteLine("¡Meec, meec!");
        }


        public override void Mostrar()
        {
            Console.WriteLine("Soy un pato de juguete");
        }
    }

    public class PatoDecorativo : Pato
    {
        public override void Mostrar()
        {
            Console.WriteLine("Soy un pato decorativo");
        }
    }
}
