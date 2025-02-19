using SixLabors.ImageSharp.PixelFormats;

namespace EstudoImagemCirculo;

public interface ILuminosidade
{
    double GetLuminosidade(Rgba32 pixelColor);
}