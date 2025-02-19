using System.Drawing;

namespace EstudoImagemCirculo;

public class PrintImagem
{
    public void Print(Matriz matriz, double saturacao, int tamanhoPixelBola, int resolucao)
    {
        var height = (tamanhoPixelBola) * matriz.Coordenadas.Max(p => p.Y);
        var width= (tamanhoPixelBola) * matriz.Coordenadas.Max(p => p.X);
        
        // Cria um novo bitmap com a largura e altura especificadas
        using (Bitmap bitmap = new Bitmap(width,height))
        {
            var g = Graphics.FromImage(bitmap);
            g.Clear(Color.White); // Define o fundo como branco
                
            foreach (var item in matriz.Coordenadas)
            {
                var brush = new SolidBrush(Color.Black);

                var tamanhoElipse = (float)Math.Truncate(item.Luminosidade * saturacao);
                var raioBola = tamanhoElipse / 2;
                var x = (item.X * tamanhoPixelBola) - raioBola;
                var y = (item.Y * tamanhoPixelBola) - raioBola;
                
                g.FillEllipse(brush, x, y, tamanhoElipse, tamanhoElipse);
                
                //g.FillRectangle(brush, x, y, tamanhoElipse, tamanhoElipse);
            }
            
            // Salva a imagem em formato JPEG
            var filePath = $"../../../../Gerado resolucao{resolucao} saturacao {saturacao} tamanhoPixelBola{tamanhoPixelBola} - {DateTime.Now.ToString("hh_mm_ss")}.jpg";
            var directoryPath = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);
            
            bitmap.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        Console.WriteLine("Imagem criada com sucesso!");
    }  
}