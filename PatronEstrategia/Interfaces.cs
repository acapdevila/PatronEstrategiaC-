using System;

namespace PatronEstrategia
{
    public interface IVolar
    {
        void Volar();
    }

    public interface IGraznar
    {
        void Graznar();
    }


    public class VolarConAlas : IVolar
    {
        public void Volar()
        {
            Console.WriteLine("Volando con alas");
        }
    }

    public class NoVolar : IVolar
    {
        public void Volar()
        {
            Console.WriteLine("No puedo volar");
        }
    }

    public class VolarConoUnCohete : IVolar
    {
        public void Volar()
        {
            Console.WriteLine("Volando como un cohete");
        }
    }


    public class GraznarComoUnPato : IGraznar
    {
        public void Graznar()
        {
            Console.WriteLine("¡Cuac, cuac!");
        }
    }

    public class GraznarComoUnaBocina : IGraznar
    {
        public void Graznar()
        {
            Console.WriteLine("¡Meec, meec!");
        }
    }

    public class GraznarEnSilencio : IGraznar
    {
        public void Graznar()
        {
            Console.WriteLine("");
        }
    }
}
