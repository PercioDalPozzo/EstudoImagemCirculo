using SixLabors.ImageSharp.PixelFormats;

namespace EstudoImagemElipse;

public interface ILuminosidade
{
    double GetLuminosidade(Rgba32 pixelColor);
}