using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAlumnos
{
    internal class Calificacion
    {
        #region Atributos 
        private double calificacion;
        private double nota1, nota2, nota3;
        private double promedio;
        #endregion

        #region Constructor
        public Calificacion()
        {
            OrdenarAlumnos();
            getCalificacion();
           
        }
        #endregion


        #region Metodos 

        public void OrdenarAlumnos() //Método que se encarga de ordenar alfabeicamente los nombres de los alumnos
        {
            ArrayList arrayNombres = new ArrayList(); // arreglo que se encarga de almacenar los nombres de los alumnos
            
            arrayNombres.Add("Esme");
            arrayNombres.Add("Adair");
            arrayNombres.Add("Jacob");
            arrayNombres.Add("Armando");
            arrayNombres.Add("Gael");

            arrayNombres.Sort(); // Imprimir los nombres de los alumnos (no ordenados)
            Console.WriteLine("Lista de alumnos");
            foreach (var nombre in arrayNombres)
            {
                Console.WriteLine(nombre);
                Console.ReadLine();
            }

            Console.WriteLine("Lista de alumnos agregada");
            PrintValues(arrayNombres); //imprimir los nombres de los alumnos


            arrayNombres.Sort();


            Console.WriteLine("Ordenados Alfabeticamente");
            PrintValues(arrayNombres);
            Console.ReadLine();
        }

        public double getCalificacion() // Metodo que se encarga de obtener las notas de los alumnos y posteriormente dobtener el promedio para asi indicar si es calificacion aprobatoria o reprobatoria
        {
            
            //entradas

            Console.Write("Ingrese la nota del primer examen: ");

            nota1 = double.Parse(Console.ReadLine()); 

            Console.Write("Ingrese la nota del segundo examen: ");

            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota del tercer examen: ");

            nota3 = double.Parse(Console.ReadLine()); 
            promedio +=( (nota1 + nota2 + nota3) / 3); //calculo del promedio de las tres calificaciones (las entradas)

            Console.WriteLine("La nota del estudiante es: " + promedio);

            // Condiciones que se aplicarán para ver si el alumno tendrá un promedio aprobatorio
            if (promedio < 6)
            {
                Console.WriteLine("Calificacion reprobatoria");
            }
            else if (promedio >= 6)
            {
                Console.WriteLine("Calificacion aprobatoria");
            }
            else
            {
                promedio = calificacion;
            }

            return calificacion;
            
        }   

        public static void PrintValues(IEnumerable arrayNombres) // Método que se encarga de ordenar alfabeticamente los nombres 
        {
            
            foreach (Object obj in arrayNombres)

                Console.WriteLine("   {0}", obj);
                Console.WriteLine();
                Console.ReadLine();
        }

        #endregion 
    }
}
