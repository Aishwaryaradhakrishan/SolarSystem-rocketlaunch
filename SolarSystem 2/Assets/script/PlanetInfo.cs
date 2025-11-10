using UnityEngine;

public class PlanetInfo : MonoBehaviour
{
    [SerializeField] private Vector3 positionOffset;

    public GameObject infoCanvas;

    public void ShowInfo()
    {
        if (infoCanvas != null)
            //infoCanvas.transform.position = transform.position + positionOffset;
            infoCanvas.SetActive(true);
    }

    public void HideInfo()
    {
        if (infoCanvas != null)
            infoCanvas.SetActive(false);
    }
}
