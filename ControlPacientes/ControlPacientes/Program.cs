using System;
using System.Reflection.Emit;
namespace ControlPacientes
{
    class Clinica
    {
        static void Main(string[] args)
        {   //Declaracion de variables y dimensionamiento de arreglos limitados en tamaño
            string[] paciente; paciente = new string[4];
            string[] medico; medico = new string[4];
            string[,] agenda; agenda = new string[4, 3];
            int cont = 0, op = 0;
            Console.WriteLine("Agenda de Atenciones Medicas!");
            bool menu = true;
            while (menu)
            {
                Console.WriteLine("1. Agregar atención medica");
                Console.WriteLine("2. Consulta por atención..");
                Console.WriteLine("3. Listar agenda atenciones");
                Console.WriteLine("4. Salir……………………...........");
                Console.WriteLine("Elige una de las opciones");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Agregar atención medica");
                        for (int i = 0; i < paciente.Length; i++)
                        {
                            Console.Write("Ingrese el nombre del paciente:");
                            paciente[i] = Console.ReadLine();
                            Console.Write("Ingrese el nombre del medico:");
                            medico[i] = Console.ReadLine();
                            for (int j = 0; j < agenda.GetLength(1); j++)
                            {
                                Console.Write("Ingrese dia de atencion:");
                                string dia = Console.ReadLine();
                                agenda[i, j] = dia;
                            }
                        }
                        Console.Write("Consultas Ingresadas, verifique en listado!!!!\n");
                        break;

                    case 2:
                        Console.WriteLine("Consulta por atención medica");
                        Console.Write("Ingrese el nombre del paciente:");
                        int enc = 0;
                        string pac = Console.ReadLine();
                        for (int i = 0; i < paciente.Length; i++)
                        {
                            int resul = pac.CompareTo(paciente[i]);
                            if (resul == 0)
                            {
                                Console.Write(paciente[i] + " ");
                                for (int j = 0; j < agenda.GetLength(1); j++)
                                {
                                    Console.Write(agenda[i, j] + " ");
                                }
                                Console.Write(medico[i] + " ");
                                Console.Write("\n");
                                enc = 1;
                            }
                        }
                        if (enc == 0) Console.WriteLine("Paciente no existe!!!!!");
                        break;

                    case 3:
                        Console.WriteLine("Listado de  atención medica");
                        Console.WriteLine("===========================");
                        for (int i = 0; i < paciente.Length; i++)
                        {
                            Console.Write(paciente[i] + " ");
                            for (int j = 0; j < agenda.GetLength(1); j++)
                            {
                                Console.Write(agenda[i, j] + " ");
                            }
                            Console.Write(medico[i] + " ");
                            Console.Write("\n");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Saliendo de aplicacion medica");
                        menu = false; break;

                    default: Console.WriteLine("Opciones validas entre 1 y 4"); break;

                }
            }
        }
    }
}