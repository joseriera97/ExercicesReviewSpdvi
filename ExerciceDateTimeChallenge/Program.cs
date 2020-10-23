using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceDateTimeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            //Obtener la fecha actual.
            var now = DateTime.Now;

            /*
            //Obtener Dia /Mes /Año
            Console.WriteLine(now.ToString("d/MM/yyyy"));
            //Obtener Mes / Dia / Año
            Console.WriteLine(now.ToString("MM/d/yyyy"));
            Console.WriteLine(now.ToShortDateString());
            */

            //Ejercicio.
            //Captura una fecha de la consola y calcula cuántos días hace.
            //Luego captura una hora de la consola y calcula cuántas horas y minutos hace que fue
            
            //Solicitamos la fecha.
            Console.WriteLine("Give me a date: (Dia/ Mes /Año | dd/MM/YYYY)");
            //Obtenemos la fecha seleccionada.
            string diaSeleccionado = Console.ReadLine();
            //Ahora debemos pasar-lo a un Date.
            DateTime fechaSeleccionada = DateTime.ParseExact(diaSeleccionado, "d/MM/yyyy", null);

            TimeSpan diasEntreFecha = now.Subtract(fechaSeleccionada);
            Console.WriteLine("La fecha seleccionada a sido " + fechaSeleccionada.ToString("d/MM/yyyy") + " fue hace " + diasEntreFecha.Days + " dias.");

            ///////////////////////////////////////////////
            //Parte de la hora
            Console.WriteLine();
            //Solicitamos la hora
            Console.WriteLine("Give me a time : (0 a 12 am/pm)");
            //Obtenemos la hora seleccionada.
            string horaSeleccionada = Console.ReadLine();
            //Ahora lo pasamos a Date de hora
            DateTime horaSeleccionadaDate = DateTime.ParseExact(horaSeleccionada, "h:m tt", null);
            //Obtener la diferencia de hora y minutos.
            TimeSpan tiempoEntreHoras = now.Subtract(horaSeleccionadaDate);
            Console.WriteLine("La hora seleccionada fue " + horaSeleccionadaDate.ToShortTimeString() + ". La diferencia de horas es: " + tiempoEntreHoras.Hours + " h y : " + tiempoEntreHoras.Minutes + " minutos.");

            
            BonusStart();




            //Para adornar y poder ver el resultado ya que a mi se me cierra al mostrar el contenido.
            Console.WriteLine();

            Console.WriteLine("Presione una tecla para continuar.");

            Console.ReadLine();
        }

        private static string  BonusStart()
        {
            //Obtener la fecha actual.
            var now = DateTime.Now;
            string finish = "";
            ////////////////////////////////////////////
            //Bonus
            ////////////////////////////////////////////
            Console.WriteLine();
            Console.WriteLine("-----------BONUS-----------------");
            Console.WriteLine();
            Console.WriteLine("Give me a date: ");
            ///////Parte de la fecha
            //Obtenemos la fecha seleccionada.
            string diaSeleccionado = Console.ReadLine();

            //Solicitar el formato para la fecha.
            Console.WriteLine("Format date: (dd/MM/YYYY | MM/dd/yy | MM/d/yyyy)");
            string formatoDia = Console.ReadLine();

            //Ahora debemos pasar-lo a un Date.
            DateTime fechaSeleccionada = DateTime.ParseExact(diaSeleccionado, formatoDia, null);

            TimeSpan diasEntreFecha = now.Subtract(fechaSeleccionada);
            Console.WriteLine("La fecha seleccionada a sido " + fechaSeleccionada.ToString("d/MM/yyyy") + " fue hace " + diasEntreFecha.Days + " dias.");

            /////////////////Parte de la hora.
            Console.WriteLine();
            //Solicitamos la hora
            Console.WriteLine("Give me a time : ");
            //Obtenemos la hora seleccionada.
            string horaSeleccionada = Console.ReadLine();
            Console.WriteLine("Format time: ( H:m  / h:m )" );
            string tipoHoraSeleccionada = Console.ReadLine();

            string horaFinal = "";
            DateTime horaSeleccionadaDate = now;
            //Si es de tipo 24h
            if (tipoHoraSeleccionada == "H:m") {
                 horaFinal = tipoHoraSeleccionada;
                //Ahora lo pasamos a Date de hora""
                 horaSeleccionadaDate = DateTime.ParseExact(horaSeleccionada, horaFinal, null);
            }//Si es de tipo 12h am/pm
            else {
                 horaFinal = tipoHoraSeleccionada;
                //Ahora lo pasamos a Date de hora""
                 horaSeleccionadaDate = DateTime.ParseExact(horaSeleccionada, horaFinal + " tt", null);
            }




            //Obtener la diferencia de hora y minutos.
            TimeSpan tiempoEntreHoras = now.Subtract(horaSeleccionadaDate);
            Console.WriteLine("La hora seleccionada fue " + horaSeleccionadaDate.ToShortTimeString() + ". La diferencia de horas es: " + tiempoEntreHoras.Hours + " h y : " + tiempoEntreHoras.Minutes + " minutos.");



            return finish;
        }

    }
}
