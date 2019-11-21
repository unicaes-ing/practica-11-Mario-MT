using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica11
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingrese su nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese su numero de telefono: ");
                string telefono = Console.ReadLine();
                Console.Write("Ingrese su fecha de nacimiento: ");
                string Fdnacimiento = Console.ReadLine();
                Console.Write("Ingrese su salario: ");
                decimal salario = Convert.ToDecimal(Console.ReadLine());
                FileStream stream = new FileStream("empleados.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter binario = new BinaryWriter(stream);
                binario.Write(nombre);
                binario.Write(telefono);
                binario.Write(Fdnacimiento);
                binario.Write(salario);
                stream.Close();
                binario.Close();
                Console.WriteLine();
                Console.WriteLine("Los datos se almacenaron con exito...");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("ocurrio un problema al crear su archivo bimario...");
                Console.ReadKey();
            }
        }
    }
}
