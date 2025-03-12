using System.Drawing;
using System.Drawing.Imaging;

namespace EstudoImagemElipse;

public class PrintImagem
{
    public void Print(Matriz matriz, double saturacao, int tamanhoPixel, int resolucao)
    {
        var margem = tamanhoPixel * 2;
        var height = tamanhoPixel * matriz.Coordenadas.Max(p => p.Y) + margem;
        var width = tamanhoPixel * matriz.Coordenadas.Max(p => p.X) + margem;

        using (var bitmap = new Bitmap(width, height))
        {
            var g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);

            foreach (var item in matriz.Coordenadas)
            {
                var brush = new SolidBrush(Color.Black);

                var tamanhoElipse = (float)Math.Truncate(item.Luminosidade * saturacao);
                var raio = tamanhoElipse / 2;
                var x = item.X * tamanhoPixel + tamanhoPixel - raio;
                var y = item.Y * tamanhoPixel + tamanhoPixel - raio;

                //Elipse
                g.FillEllipse(brush, x, y, tamanhoElipse, tamanhoElipse);

                //Quadrado
                //g.FillRectangle(brush, x, y, tamanhoElipse, tamanhoElipse);

                //Delimitador. Guia para conferencia
                //g.DrawRectangle(new Pen(Color.Red, 1), (item.X * tamanhoPixel) + (tamanhoPixel/2), (item.Y * tamanhoPixel) + (tamanhoPixel/2), tamanhoPixel, tamanhoPixel);                
            }

            // Salva a imagem em formato JPEG
            var filePath =
                $"../../../../Gerado resolucao{resolucao} saturacao {saturacao} tamanhoPixel{tamanhoPixel} - {DateTime.Now.ToString("hh_mm_ss")}.jpg";
            var directoryPath = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            bitmap.Save(filePath, ImageFormat.Jpeg);
        }

        Console.WriteLine("Imagem criada com sucesso!");
    }
}