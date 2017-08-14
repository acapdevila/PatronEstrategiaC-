using System;

namespace PatronEstrategia
{
    class Program
    {
        static void Main(string[] args)
        {
            var patoDomestico  = new PatoDomestico();

            patoDomestico.Mostrar();
            patoDomestico.Graznar();
            patoDomestico.Nadar();
            patoDomestico.Volar();


            var patoPelirrojo = new PatoPelirrojo();

            patoPelirrojo.Mostrar();
            patoPelirrojo.Graznar();
            patoPelirrojo.Nadar();
            patoPelirrojo.Volar();


            var patoDeJuguete = new PatoDeJuguete();

            patoDeJuguete.Mostrar();
            patoDeJuguete.Graznar();
            patoDeJuguete.Nadar();
            patoDeJuguete.Volar();


            Console.ReadLine();
        }
    }
}
