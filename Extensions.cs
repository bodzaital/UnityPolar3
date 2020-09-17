using UnityEngine;

static class Extensions
{
    /// <summary>
    /// Converts a <see cref="Vector3"/> in world space to a <see cref="Polar2"/>.
    /// </summary>
    /// <param name="v">World space vector.</param>
    /// <param name="sphere">The sphere on which the vector is on.</param>
    /// <returns></returns>
    public static Polar2 ToPolar2(this Vector3 v, Transform sphere)
    {
        Vector3 pos = v - sphere.position;

        Vector3 azimuthReference = Quaternion.Euler(sphere.rotation.eulerAngles.x, sphere.rotation.eulerAngles.y, sphere.rotation.eulerAngles.z) * new Vector3(0, 0, -1 * (sphere.localScale.z / 2));
        //Vector3 rightAzimuthReference = Quaternion.Euler(sphere.rotation.eulerAngles.x, sphere.rotation.eulerAngles.y, sphere.rotation.eulerAngles.z) * new Vector3(sphere.localScale.x, 0, 0);

        Debug.DrawLine(sphere.position, azimuthReference);

        Vector3 zenithReference = Quaternion.Euler(sphere.rotation.eulerAngles.x, sphere.rotation.eulerAngles.y, sphere.rotation.eulerAngles.z) * (Vector3.up * (sphere.localScale.x / 2));

        Debug.DrawLine(sphere.position, zenithReference);

        Debug.DrawLine(sphere.position, pos, Color.green);

        Polar2 polar = new Polar2(
            Vector3.Angle(zenithReference, pos),
            Vector3.SignedAngle(azimuthReference, Vector3.ProjectOnPlane(v - sphere.position, zenithReference), zenithReference));

        return polar;
    }
}
