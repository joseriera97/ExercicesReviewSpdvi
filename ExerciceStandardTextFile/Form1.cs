using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciceStandardTextFile
{
    public partial class Form1 : Form
    {
        //Lista de las personas
        List<Persona> personas = new List<Persona>();

        //Lista provisional sin guardar
        List<Persona> personasNoGuardado = new List<Persona>();

        String rutaArchivo = @"F:\Clase\2021\Interfaces\Projectos\Ejercicios Repaso\ExercicesReview\ExerciceStandardTextFile\data\StandardDataSet.csv";

        public Form1()
        {

            InitializeComponent();

            cargarDatosArchivo(rutaArchivo , personas);
        }

        //Cargar los datos del archivo recogido del csv
        private  List<Persona> cargarDatosArchivo(string rutaArchivo, List<Persona> personas)
        {


            //Lista de las linias del archivo.
            List<string> linias = File.ReadAllLines(rutaArchivo).ToList();

            int inicio = 0;
            foreach (var linia in linias)
            {
                if (inicio == 1)
                {
                    string[] entrada = linia.Split(',');
                    Persona nuevaPersona = new Persona();
                    nuevaPersona.FirstName = entrada[0];
                    nuevaPersona.LastName = entrada[1];
                    int edad = Int32.Parse(entrada[2]);
                    nuevaPersona.Age = edad;
                    Boolean estado;
                    if (entrada[3] == "0")
                    {
                        estado = true;
                    }
                    else
                    {
                        estado = false;
                    }
                    nuevaPersona.Alive = estado;
                    personas.Add(nuevaPersona);
                }
                else {
                    inicio = 1;
                }

            }


            //Vaciar los items que tengamos en el ListBox
            peopleListBox.Items.Clear();
            // Hago un bucle según la grandaria del array de String para introducir item por item.
            //Se empieza en la posicion 1 porque en la 0 contiene la información de la tabla.
            foreach (var item in personas)
            {
                string estado;
                if (item.Alive == false) { estado = " dead"; } else { estado = " alive"; }

                peopleListBox.Items.Add(" " + item.FirstName + " " + item.LastName + " is " + item.Age + " and is" + estado); 

            }

            return personas;

        }
        private void addUserButton_Click(object sender, EventArgs e)
        {
            //Lista provisional sin guardar
             personasNoGuardado = personas;

            //Obtenemos los valores introducidos y los incertamos en la lista.
            Persona newPerson = new Persona { FirstName = fNameTextBox.Text, LastName = lNameTextBox.Text, Age = Decimal.ToInt32(ageNumericUpDown.Value), Alive = aliveCheckBox.Checked };

            personasNoGuardado.Add(newPerson);

            //Volvemos a cargar el listado.Pero esta vez con la lista Provisional.
            //Vaciar los items que tengamos en el ListBox
            peopleListBox.Items.Clear();
            // Hago un bucle según la grandaria del array de String para introducir item por item.
            //Se empieza en la posicion 1 porque en la 0 contiene la información de la tabla.
            foreach (var item in personasNoGuardado)
            {
                string estado;
                if (item.Alive == false) { estado = " dead"; } else { estado = " alive"; }

                peopleListBox.Items.Add(" " + item.FirstName + " " + item.LastName + " is " + item.Age + " and is" + estado);

            }

            //Reseteamos los valores
            LimpiarValores();
        }
        private void LimpiarValores()
        {
            fNameTextBox.Text = ""; 
            lNameTextBox.Text = ""; 
            ageNumericUpDown.Value = 0; 
            aliveCheckBox.Checked = false;
        }


        //Guardar la lista provisional como definitiva en el documento.
        private void saveListButton_Click(object sender, EventArgs e)
        {
            //La lista de Personas no Guardadas es personasNoGuardado
            List<string> salida = new List<string>();
            //Introducimos el primer string de linea
            salida.Add("FirstName,LastName,Age,IsAlive");
            //Realizamos un bucle para introducir por linea el conjunto de datos de cada persona.
            foreach (var textoPersona in personasNoGuardado)
            {
                salida.Add($"{textoPersona.FirstName },{textoPersona.LastName },{textoPersona.Age },{textoPersona.Alive }");
            }
            //Escribimos en el archivo el nuevo contenido. Siguiendo la estructura inicial de Ejemplo.
            File.WriteAllLines(rutaArchivo, salida);
        }
    }
}
