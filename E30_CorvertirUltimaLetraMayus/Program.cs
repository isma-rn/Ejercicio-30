using System;
using System.Text;

namespace E30_CorvertirUltimaLetraMayus
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            string opcion, cadena;
            do
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Ingrese cadena");
                cadena = Console.ReadLine();
                cadena = cadena.Trim();

                if( cadena.Length>0)                
                    Console.WriteLine("la cadena es \"{0}\", el resultado es \"{1}\"", cadena, ConvertirUltimaLetraAMayuscula(cadena.ToCharArray()));                
                else                
                    Console.WriteLine("Cadena vacía");
                
                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("n : nuevo, s : salir");
                    opcion = Console.ReadLine();

                    if (opcion.Equals("s"))
                    {
                        salir = true;
                        break;
                    }
                    else if (!opcion.Equals("n"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No se reconoce opción...");
                    }
                    else
                        break;
                } while (true);

            } while (!salir);
        }

        public static string ConvertirUltimaLetraAMayuscula(char[] cadena)
        {
            StringBuilder resultado = new StringBuilder();

            for(int i = 0; i<cadena.Length; i++)
                if ( i != (cadena.Length-1) )
                    resultado.Append( cadena[i] );
                else
                    resultado.Append( cadena[i].ToString().ToUpper() );
            
            return resultado.ToString();
        }
    }
}
