using System;

class Program
{
    static void Main(string[] args)
    {
        string[] funcionario = new string[10];
        string[] cargo = new string[10];
        int[] sueldo = new int[10];

        int opcion = 0;

        while (opcion != 5)
        {
            Console.WriteLine("\n=== MENÚ PRINCIPAL ===");
            Console.WriteLine("1) Agregar datos");
            Console.WriteLine("2) Consultar datos");
            Console.WriteLine("3) Modificar registro");
            Console.WriteLine("4) Listar funcionarios");
            Console.WriteLine("5) Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            // OPCIÓN 1: AGREGAR DATOS
            if (opcion == 1)
            {
                bool agregado = false;

                for (int i = 0; i < 10; i++)
                {
                    if (funcionario[i] == null)
                    {
                        Console.Write("Ingrese nombre del funcionario: ");
                        funcionario[i] = Console.ReadLine();

                        Console.Write("Ingrese cargo del funcionario: ");
                        cargo[i] = Console.ReadLine();

                        Console.Write("Ingrese sueldo del funcionario: ");
                        sueldo[i] = int.Parse(Console.ReadLine());

                        Console.WriteLine("Registro agregado correctamente.");
                        agregado = true;
                        break;
                    }
                }

                if (!agregado)
                {
                    Console.WriteLine("No hay espacio disponible para agregar más funcionarios.");
                }
            }

            // OPCIÓN 2: CONSULTAR DATOS
            else if (opcion == 2)
            {
                Console.Write("Ingrese el nombre a buscar: ");
                string nombreBuscado = Console.ReadLine();

                bool encontrado = false;

                for (int i = 0; i < 10; i++)
                {
                    if (funcionario[i] != null && funcionario[i] == nombreBuscado)
                    {
                        Console.WriteLine("\n=== REGISTRO ENCONTRADO ===");
                        Console.WriteLine("Nombre: " + funcionario[i]);
                        Console.WriteLine("Cargo: " + cargo[i]);
                        Console.WriteLine("Sueldo: " + sueldo[i]);
                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("El funcionario no existe en el registro.");
                }
            }

            // OPCIÓN 3: MODIFICAR REGISTRO
            else if (opcion == 3)
            {
                Console.Write("Ingrese el nombre del funcionario a modificar: ");
                string nombreModificar = Console.ReadLine();

                bool encontrado = false;

                for (int i = 0; i < 10; i++)
                {
                    if (funcionario[i] != null && funcionario[i] == nombreModificar)
                    {
                        Console.WriteLine("\nRegistro encontrado. Datos actuales:");
                        Console.WriteLine("Nombre: " + funcionario[i]);
                        Console.WriteLine("Cargo: " + cargo[i]);
                        Console.WriteLine("Sueldo: " + sueldo[i]);

                        Console.WriteLine("\nIngrese los nuevos datos:");

                        Console.Write("Nuevo nombre: ");
                        funcionario[i] = Console.ReadLine();

                        Console.Write("Nuevo cargo: ");
                        cargo[i] = Console.ReadLine();

                        Console.Write("Nuevo sueldo: ");
                        sueldo[i] = int.Parse(Console.ReadLine());

                        Console.WriteLine("Registro modificado correctamente.");
                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("El funcionario no existe en el registro.");
                }
            }

            // OPCIÓN 4: LISTAR FUNCIONARIOS
            else if (opcion == 4)
            {
                Console.WriteLine("\n=== LISTADO DE FUNCIONARIOS ===");

                bool hayDatos = false;

                for (int i = 0; i < 10; i++)
                {
                    if (funcionario[i] != null)
                    {
                        Console.WriteLine("\nRegistro " + i);
                        Console.WriteLine("Nombre: " + funcionario[i]);
                        Console.WriteLine("Cargo: " + cargo[i]);
                        Console.WriteLine("Sueldo: " + sueldo[i]);
                        hayDatos = true;
                    }
                }

                if (!hayDatos)
                {
                    Console.WriteLine("No hay funcionarios registrados.");
                }
            }
        }

        Console.WriteLine("Saliendo de la aplicación...");
    }
}
