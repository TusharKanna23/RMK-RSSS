using UnityEngine;

public class MapUI : MonoBehaviour
{
    public GameObject mapPanel;

    public void OpenMap()
    {
        mapPanel.SetActive(true);
    }

    public void CloseMap()
    {
        mapPanel.SetActive(false);
    }
}