using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEncapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos una instancia de contacto
            Contacto contactoUno = new Contacto();

            contactoUno.Nombre = "José García";
            contactoUno.Direccion = "Veracruz S/N";
            contactoUno.correoElectronico = "josegarcia@correo.com";
            contactoUno.TelefonoCasa = "1234567890";
            contactoUno.TelefonoCelular = "9877";
            Console.WriteLine("Nombre: " + contactoUno.Nombre);
            Console.WriteLine("Direccion: " + contactoUno.Direccion);
            Console.WriteLine("Correo Electronico: " + contactoUno.correoElectronico);
            Console.WriteLine("Telefono de casa: " + contactoUno.TelefonoCasa);
            Console.WriteLine("Telefono celular: " + contactoUno.TelefonoCelular);
            Console.ReadLine();

        }
    }
}
