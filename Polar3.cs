using System;
using System.Text;

/// <summary>
/// A polar coordinate describing a position using radius, inclination, and azimuth.
/// </summary>
public class Polar3
{
    /// <summary>
    /// The Euclidean distance from the origin O to point P.
    /// </summary>
    public float Radius { get; set; }

    /// <summary>
    /// Polar angle; the angle between the zenith and the line OP.
    /// </summary>
    public float Inclination { get; set; }

    /// <summary>
    /// Azimuthal angle; the signed angle from the azimuth reference direction to the projection of the line OP on the reference plane.
    /// </summary>
    public float Azimuth { get; set; }

    /// <summary>
    /// Creates a new polar coordinate.
    /// </summary>
    /// <param name="radius">The radius.</param>
    /// <param name="inclination">The polar angle.</param>
    /// <param name="azimuth">The azimuthal angle.</param>
    public Polar3(float radius, float inclination, float azimuth)
    {
        Radius = radius;
        Inclination = inclination;
        Azimuth = azimuth;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("r: ");
        sb.Append(Math.Round(Radius, 1));
        sb.Append(", θ: ");
        sb.Append(Math.Round(Inclination, 1));
        sb.Append(", φ: ");
        sb.Append(Math.Round(Azimuth, 1));
        return sb.ToString();
    }
}
