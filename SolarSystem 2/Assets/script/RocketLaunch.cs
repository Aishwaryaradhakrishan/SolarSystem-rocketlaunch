using UnityEngine;

public class RocketLaunch : MonoBehaviour
{
    public float launchSpeed = 5f;

    public AudioClip AudioClip;
    private bool launched = false;

    public void LaunchRocket()
    {
        launched = true; 
    }

    void Update()
    {

        if (launched)
        {
            transform.Translate(Vector3.up * launchSpeed * Time.deltaTime);
        }
    }
}
