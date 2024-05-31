using System;
using System.Collections.Generic;

namespace calendario_de_actividades
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> actividades = new List<string>{ "" };
            menuOpciones();
            Console.ReadKey();

            void menuOpciones()
            {
                string opcion;
                Console.Clear();
                Console.WriteLine("=== Menu de Opciones ===");
                Console.WriteLine("1. Agregar actividad");
                Console.WriteLine("2. Eliminar actividad");
                Console.WriteLine("3. Mostrar todas las actividades");
                Console.WriteLine("4. Salir");
                Console.Write("========================\nSelecciona una opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        crearActividad();
                        break;
                    case "2":
                        eliminarActividad();
                        break;
                    case "3":
                        mostrarActividades();
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("No forma parte de las opciones");
                        Console.ReadKey();
                        menuOpciones();
                        break;
                }
            }
            void crearActividad()
            {
                Console.Clear();
                Console.Write("¿Qué actividad desea agregar? ");
                string actividad = Console.ReadLine();
                actividades.Add(mayus(actividad));
                menuOpciones();
            }
            void eliminarActividad()
            {
                try
                {
                    Console.Clear();
                    for (int i = 1; i < actividades.Count; i++)
                    {
                        Console.WriteLine($"{i}. {actividades[i]}");
                    }
                    Console.Write("¿Qué actividad desea eliminar? ");
                    int res = int.Parse(Console.ReadLine());
                    if (res >= 1 && res < actividades.Count)
                    {
                        actividades.RemoveAt(res);
                    }
                    else
                    {
                        Console.WriteLine("No forma parte de las opciones");
                        Console.ReadKey();
                    }
                    menuOpciones();
                }
                catch (Exception)
                {
                    Console.WriteLine("No forma parte de las opciones");
                    Console.ReadKey();
                    menuOpciones();
                }
            }
            void mostrarActividades()
            {
                Console.Clear();
                for (int i = 1; i < actividades.Count; i++)
                {
                    Console.WriteLine($"{i}. {actividades[i]}");
                }
                Console.ReadKey();
                menuOpciones();
            }
        }
        public static string mayus(string palabra)
        {
            palabra = palabra.ToLower();
            char primeraLetra = char.ToUpper(palabra[0]);
            return primeraLetra + palabra.Substring(1);
        }
    }
}
