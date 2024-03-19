namespace FicheroSobreescribirLinea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rutaArchivo = "archivo.txt";
            Console.WriteLine("Escriba numero de una linea");
            int numeroLinea = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el texto a reeemplazar");
            string textoNuevo = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(rutaArchivo))
            {
                // Escribir algo en el archivo
                writer.WriteLine("Linea 1\n" +
                    "Linea 2\n" +
                    "Linea 3\n" +
                    "Linea 4\n" +
                    "Linea 5.");
            }

            try
            {
                string[] lineas = File.ReadAllLines(rutaArchivo);
                if (numeroLinea >= 1 && numeroLinea <= lineas.Length)
                {
                    // Reemplazar el contenido de la línea específica
                    lineas[numeroLinea - 1] = textoNuevo;

                    // Sobrescribir el archivo con las líneas actualizadas
                    File.WriteAllLines(rutaArchivo, lineas);

                    Console.WriteLine("El texto se ha escrito correctamente en la línea especificada.");
                }
                else
                {
                    Console.WriteLine("El número de línea especificado está fuera del rango del archivo.");
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Error al leer/escribir el archivo: " + e.Message);
            }
        }
    }
}
