using System;
using System.Collections.Generic;
using System.IO;

namespace usuarioproyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> usuarios = new List<Usuario>();

            Console.WriteLine("Ingrese la cantidad de usuarios a registrar:");
            int cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"\n--- Registro del Usuario {i + 1} ---");
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());
                Console.Write("Correo electrónico: ");
                string correo = Console.ReadLine();

                usuarios.Add(new Usuario(nombre, edad, correo));
            }

            // Mostrar los datos ingresados antes de guardarlos
            Console.WriteLine("\n--- Datos Ingresados ---");
            foreach (Usuario usuario in usuarios)
            {
                Console.WriteLine($"Nombre: {usuario.Nombre}, Edad: {usuario.Edad}, Correo: {usuario.Correo}");
            }

            GuardarUsuariosEnArchivo(usuarios);
            Console.WriteLine("\nLos datos de los usuarios han sido guardados en el archivo.");
        }

        static void GuardarUsuariosEnArchivo(List<Usuario> usuarios)
        {
            string rutaArchivo = "usuarios_registrados.txt";
            using (StreamWriter escritor = new StreamWriter(rutaArchivo))
            {
                foreach (Usuario usuario in usuarios)
                {
                    escritor.WriteLine($"Nombre: {usuario.Nombre}, Edad: {usuario.Edad}, Correo: {usuario.Correo}");
                }
            }
        }
    }
}
