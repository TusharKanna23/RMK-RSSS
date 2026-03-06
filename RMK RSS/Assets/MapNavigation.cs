using UnityEngine;

public class MapNavigation : MonoBehaviour
{
    public Transform player;

    public Transform hallOfFame;
    public Transform principalBlock;
    public Transform healthCare;

    public GameObject mapUI;

    public void GoToLocation(Transform location)
    {
        player.position = location.position;
        mapUI.SetActive(false);
    }

    public void HallOfFame()
    {
        GoToLocation(hallOfFame);
    }

    public void PrincipalBlock()
    {
        GoToLocation(principalBlock);
    }

    public void HealthCare()
    {
        GoToLocation(healthCare);
    }


}