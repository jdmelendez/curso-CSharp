using System.IO.Compression;


namespace CompresionZIPFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Comprimir archivo zip
            /*
            ZipFile.CreateFromDirectory("C:/temp/prueba/archivos", "c:/temp/prueba/ejemplo01.zip", CompressionLevel.Optimal, false);
            */

            // Descomprimir archivo zip
            /*
            ZipFile.ExtractToDirectory("C:/temp/prueba/ejemplo01.zip", "C:/temp/prueba/DireccionDestino");
            */

            // Extracción de archivos por instancias
            /*
            using (ZipArchive archivo = ZipFile.Open("C:/Temp/Prueba/Ejemplo01.zip", ZipArchiveMode.Read))
            {
                string destino = "C:/Temp/Prueba/ExtraccionZIP/";

                ZipArchiveEntry elemento1 = archivo.GetEntry("Archivo 1.txt");
                elemento1.ExtractToFile(destino + "Archivo 1.txt");

                ZipArchiveEntry elemento2 = archivo.GetEntry(@"Directorio 1\Archivo 1-1.txt");
                elemento2.ExtractToFile(destino + "Archivo 1-1.txt");
            }*/

            // Crear archivo ZIP

            using (ZipArchive archivo = ZipFile.Open("C:/Temp/Prueba/ejemplo02.zip", ZipArchiveMode.Create))
            {
                string Origen = "C:/Temp/Prueba/ExtraccionZIP/";

                archivo.CreateEntryFromFile(Origen + "Archivo 1.txt", "Archivo 1.txt", CompressionLevel.Optimal);
                archivo.CreateEntryFromFile(Origen + "Archivo 1-1.txt", @"Directorio 1\Archivo 1-1.txt", CompressionLevel.Optimal);

            }

        }
    }
}
