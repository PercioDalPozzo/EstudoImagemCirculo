using SixLabors.ImageSharp.PixelFormats;

namespace EstudoImagemElipse;

public class Luminosidade_R3_G3_B3 : ILuminosidade
{
    public double GetLuminosidade(Rgba32 pixelColor)
    {
        return 0.333 * pixelColor.R +
               0.333 * pixelColor.G +
               0.333 * pixelColor.B;
    }
}