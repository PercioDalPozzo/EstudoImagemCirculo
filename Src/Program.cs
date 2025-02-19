using SixLabors.ImageSharp; 
using SixLabors.ImageSharp.PixelFormats; 
using System.Text;
using EstudoImagemCirculo;
using EstudoImagemCirculo;

class Program
{
    // const int resolucao = 15;
    // const double saturacao = 0.4;
    // private const int tamanhoPixelBola = 20;
    
    const int resolucao = 100;
    const double saturacao = 0.4;
    private const int tamanhoPixelBola = 25;    
    
    const string imagePath = "../../../../Eu.jpg";
    
    static void Main()
    {
        using (var image = Image.Load<Rgba32>(imagePath))
        {
            Converter(image);
        }
       
        Console.WriteLine("Feito!");
    }

    private static void Converter(Image<Rgba32> image)
    {
        var matriz = new ImageConverter(image).Convert(new PixelConverter(new Luminosidade_R21_G71_B01()), resolucao);
        new PrintImagem().Print(matriz, saturacao, tamanhoPixelBola, resolucao);
    }
}

