using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertirASvg
{
    internal class UtilImage
    {
        public void ConvertirPngASvg(string inputFilePath, string outputFilePath)
        {
            // Cargar imagen PNG
            using (Image<Rgba32> imagen = SixLabors.ImageSharp.Image.Load<Rgba32>(inputFilePath))
            {
                // Crear un nuevo documento SVG
                using (StreamWriter escritor = new StreamWriter(outputFilePath))
                {
                    escritor.WriteLine("<svg xmlns='http://www.w3.org/2000/svg' width='{0}' height='{1}'>", imagen.Width, imagen.Height);
                    escritor.WriteLine("<rect width='{0}' height='{1}' fill='white' />", imagen.Width, imagen.Height);

                    // Iterar sobre cada píxel y crear un rectángulo SVG para representarlo
                    for (int y = 0; y < imagen.Height; y++)
                    {
                        for (int x = 0; x < imagen.Width; x++)
                        {
                            var color = imagen[x, y];
                            escritor.WriteLine("<rect x='{0}' y='{1}' width='1' height='1' fill='#{2}' />", x, y, ColorToHex(color));
                        }
                    }

                    escritor.WriteLine("</svg>");
                }
            }
        }

        static string ColorToHex(Rgba32 color)
        {
            return $"{color.R:X2}{color.G:X2}{color.B:X2}";
        }
    }
}
