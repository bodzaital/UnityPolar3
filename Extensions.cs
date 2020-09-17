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
        Vector3 rotated = v - sphere.position;
        rotated = Quaternion.Euler(sphere.rotation.eulerAngles.x, sphere.rotation.eulerAngles.y, sphere.rotation.eulerAngles.z) * rotated;

        Vector3 azimuthReference = Quaternion.Euler(sphere.rotation.eulerAngles.x, sphere.rotation.eulerAngles.y, sphere.rotation.eulerAngles.z) * new Vector3(0, 0, -1 *sphere.localScale.z);
        //Vector3 rightAzimuthReference = Quaternion.Euler(sphere.rotation.eulerAngles.x, sphere.rotation.eulerAngles.y, sphere.rotation.eulerAngles.z) * new Vector3(sphere.localScale.x, 0, 0);

        Polar2 polar = new Polar2(
            Vector3.SignedAngle(Vector3.up, rotated, Vector3.up),
            Vector3.SignedAngle(azimuthReference, Vector3.ProjectOnPlane(v - sphere.position, Vector3.up), Vector3.up));

        return polar;
    }
}
