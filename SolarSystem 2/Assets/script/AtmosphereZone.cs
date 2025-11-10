using UnityEngine;
using UnityEngine.SceneManagement;

public class AtmosphereZone : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(gameObject.name);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Rocket"))
        {
            SceneManager.LoadScene(1);
        }
        
    }
}
