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
          

            var patoPelirrojo = new PatoPelirrojo();

            patoPelirrojo.Mostrar();
            patoPelirrojo.Graznar();
            patoPelirrojo.Nadar();
            
            Console.ReadLine();
        }
    }
}
