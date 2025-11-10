using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        // Rotate the planet around its Y-axis
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}