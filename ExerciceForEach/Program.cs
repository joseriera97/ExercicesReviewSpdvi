using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear una lista de String y insertar el contenido deseado.
            var personas = new List<String>() { "John", "Mary", "Sue", "Greg" , "Yolanda" , "Jose" , "Bill" };

            //Realizar un blucle para mostrar por consola los nombres de la lista.
            foreach (var item in personas)
            {
                Console.WriteLine("Hello "+item);
            }
            Console.WriteLine();

            //Llamar a la clase para recoger la lista creada con PersonModel.
            List<PersonModel> listaPersonas = CreateListPerson();
            //Realizar un blucle para mostrar por consola los nombres de la lista.
            foreach (var item in listaPersonas)
            {
                Console.WriteLine("Hello " + item.FirstName + " " + item.LastName);
            }



            //Para adornar y poder ver el resultado ya que a mi se me cierra al mostrar el contenido.
            Console.WriteLine();

            Console.WriteLine("Presione una tecla para continuar.");

            Console.ReadLine();

        }

        //Metodo que utiliza la clase PersonModel para crear una lista de personas con Nombre y Apellido.
        private static List<PersonModel> CreateListPerson()
        {
            var output = new List<PersonModel>
            {
                new PersonModel{ FirstName = "Tim", LastName = "Corey"},
                new PersonModel{ FirstName = "Sue", LastName = "Storm"},
                new PersonModel{ FirstName = "Paul", LastName = "Jones"},
                new PersonModel{ FirstName = "Jane", LastName = "Smith"},
                new PersonModel{ FirstName = "Betty", LastName = "Smith"}
            };

            return output;
        }

    }
}
