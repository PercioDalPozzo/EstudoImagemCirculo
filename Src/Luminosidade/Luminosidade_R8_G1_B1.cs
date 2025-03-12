using SixLabors.ImageSharp.PixelFormats;

namespace EstudoImagemElipse;

public class Luminosidade_R8_G1_B1 : ILuminosidade
{
    public double GetLuminosidade(Rgba32 pixelColor)
    {
        return 0.8 * pixelColor.R +
               0.1 * pixelColor.G +
               0.1 * pixelColor.B;
    }
}