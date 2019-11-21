using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica11
{
    class ejercicio3
    {
        public static void MenuInicial()
        {
            Console.WriteLine("DATOS DE ALUMNO\n[1] Agregar Alumno\n[2] Mostrar Alumnos\n[3] Buscar Alumno\n[4] Salir");
            Console.Write("INGRESA UNA OPCION: ");
            int opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.Clear();
                    Ingresar();
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Mostrar();
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Buscar();
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("PRESIONA <ENTER> PARA SALIR");
                    Console.ReadKey();
                    break;

            }
        }
        static void Main(string[] args)
        {
            MenuInicial();
            Console.ReadKey();
        }
        public static void Ingresar()
        {
            try
            {
                Console.WriteLine("\nDATOS DEL ALUMNO");
                Console.WriteLine();
                Console.WriteLine("Ingresar el carnet de el alumno:");
                string carnetEstudiante = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingresar el nombre de el alumno: ");
                string nombreEstudiante = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Ingresar la edad de el alumno:");
                int edadEstudiante = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Ingresar el CUM de el alumno:");
                decimal cumEstudiante = Convert.ToDecimal(Console.ReadLine());
                FileStream stream = new FileStream("DatosCliente.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter binario = new BinaryWriter(stream);
                binario.Write(carnetEstudiante);
                binario.Write(nombreEstudiante);
                binario.Write(edadEstudiante);
                binario.Write(cumEstudiante);
                stream.Close();
                binario.Close();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("LOS DATOS SE ALMACENARON EXITOSAMENTE");
                Console.ReadKey();


            }
            catch (Exception)
            {

                Console.WriteLine("HA OCURRIDO UNERROR AL GUARDAR LOS DATOS");
            }
        }
        public static void Mostrar()
        {
            Console.WriteLine("QUE DESEAS MOSTRAR");
            Console.WriteLine();
            Console.WriteLine("[1]------------TODOS LOS ALUMNOS");
            Console.WriteLine();
            Console.WriteLine("[2]------------FILTRADOS POR EL CUM");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("ELIGE UNA OPCION:  ");
            int opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    break;
                case 2:
                    break;
            }

        }
        public static void Buscar()
        {

        }
    }
}
