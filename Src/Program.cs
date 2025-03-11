using EstudoImagemCirculo;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

internal class Program
{
    private const int resolucao = 50;
    private const double saturacao = 0.4;
    private const int tamanhoPixel = 25;
    private const string caminhoOrigem = "../../../../Eu.jpg";

    private static void Main()
    {
        using (var image = Image.Load<Rgba32>(caminhoOrigem))
        {
            Converter(image);
        }

        Console.WriteLine("Feito!");
    }

    private static void Converter(Image<Rgba32> image)
    {
        var matriz = new ImageConverter(image).Convert(new PixelConverter(new Luminosidade_R21_G71_B01()), resolucao);
        new PrintImagem().Print(matriz, saturacao, tamanhoPixel, resolucao);
    }
}