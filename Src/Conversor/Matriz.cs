namespace EstudoImagemCirculo;

public class Matriz
{
    public IList<Coordenada> Coordenadas { get; } = new List<Coordenada>();

    public void Add(int x, int y, double luminosidade)
    {
        Coordenadas.Add(new Coordenada(x, y, luminosidade));
    }
}

public record Coordenada(int X, int Y, double Luminosidade)
{
}