/// <summary>
/// A polar coordinate describing a position using inclination, and azimuth for coordinates on a sphere.
/// </summary>
class Polar2 : Polar3
{
    /// <summary>
    /// Creates a new polar coordinate where the radius is always 0.
    /// </summary>
    /// <param name="inclination">The polar angle.</param>
    /// <param name="azimuth">The azimuthal angle.</param>
    public Polar2(float inclination, float azimuth) : base(0, inclination, azimuth)
    {

    }
}
