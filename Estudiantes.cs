using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Estudiantes
    {
        Byte[] edades = new byte[0];
        int posicion = 0;
        public void insertar()
        {
            String seguir;
            byte ed;
            do
            {
                Console.WriteLine("\nINGRESE EDAD: ");
                while (!byte.TryParse(Console.ReadLine(), out ed) || ed < 14 || ed > 120)
                {
                    Console.Write("ERROR: INGRESAR EDAD: ");
                }
                Array.Resize(ref edades, edades.Length + 1);
                edades[posicion] = ed;
                posicion++;
                Console.WriteLine("\nEDAD REGISTRADA CORRECTAMENTE");
                Console.Write("\nDESEA SEGUIR REGISTRANDO? [SI]:");
                seguir = Console.ReadLine().ToUpper();
            } while (seguir == "SI");
        }
        public void mostrar()
        {
            Console.SetCursorPosition(10, 10);
            Console.Write("POSICION");
            Console.SetCursorPosition(30, 10);
            Console.Write("EDADES");
            for (int i = 0; i < edades.Length; i++)
            {
                Console.SetCursorPosition(10, 11 + i);
                Console.Write(i);
                Console.SetCursorPosition(30, 11 + i);
                Console.Write(edades[i]);
            }
        }
        public void eliminar (byte ed)
        {
            int indice = Array.IndexOf(edades, ed); 
            if (indice != -1)
            {
                for (int i = indice; i < edades.Length -1; i++)
                {
                    edades[i] = edades[i + 1];
                }
                Array.Resize(ref edades, edades.Length - 1);
                posicion--;
                Console.WriteLine("EDAD ELIMINADA CORRECTAMENTE: ");
            }
            else
            {
                Console.WriteLine("\nNO SE PUEDE ELIMINAR PORQUE NO EXISTE");
            }
        }
    }
}
