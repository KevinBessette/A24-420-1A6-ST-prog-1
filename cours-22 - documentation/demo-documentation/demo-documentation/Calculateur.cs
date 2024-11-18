/// <summary>
/// Fournit des méthodes de calcul de base.
/// </summary>
public static class Calculateur
{
    /// <summary>
    /// Obtient ou définit le multiplicateur global pour tous les calculs.
    /// </summary>
    /// <value>Le multiplicateur global pour les calculs.</value>
    public static double Multiplicateur = 1.0;

    /// <summary>
    /// Calcule le produit de deux nombres, multiplié par le multiplicateur global.
    /// </summary>
    /// <param name="x">Le premier nombre.</param>
    /// <param name="y">Le second nombre.</param>
    /// <returns>Le produit des deux nombres, ajusté par le multiplicateur global.</returns>
    public static double Multiplier(double x, double y)
    {
        return x * y * Multiplicateur;
    }

    /// <summary>
    /// Calcule le produit d'un nombres multiplié par le multiplicateur global.
    /// </summary>
    /// <param name="x">Le nombre à multiplié par le multiplicateur</param>
    /// <returns>le produit du nombre multiplié par le multiplicateur global.</returns>
    public static double Multiplier(double x)
    {
        return x * Multiplicateur;
    }

}