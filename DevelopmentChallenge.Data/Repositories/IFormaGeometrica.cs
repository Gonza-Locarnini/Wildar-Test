
namespace DevelopmentChallenge.Data.Repositories
{
    public interface IFormaGeometrica
    {
        decimal GetArea();
        decimal GetPerimetro();

        string Label { get; }

        string PluralLabel { get; }
    }
}
