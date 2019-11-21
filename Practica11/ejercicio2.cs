using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica11
{
    class ejercicio2
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream stream = new FileStream("empleados.dat", FileMode.Open, FileAccess.Read);
                BinaryReader binario = new BinaryReader(stream);
                string nombre = binario.ReadString();
                string telefono = binario.ReadString();
                string Fdnacimiento = binario.ReadString();
                decimal salario = binario.ReadDecimal();
                stream.Close();
                binario.Close();
                Console.WriteLine("Datos del empleado:");
                Console.WriteLine();
                Console.WriteLine("Nombre del empleado: {0}", nombre);
                Console.WriteLine("Numero telefonico: {0}", telefono);
                Console.WriteLine("Fecha de nacimento: {0}", Fdnacimiento);
                Console.WriteLine("Salario {0:C2}", salario);
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para salir");
                Console.ReadLine();
            }
            catch (Exception)
            {

                Console.WriteLine("Ocurrio un error con el archivo binario...");
                Console.ReadKey();
            }
        }
    }
}
