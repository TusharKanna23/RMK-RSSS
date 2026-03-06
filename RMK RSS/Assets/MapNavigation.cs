using UnityEngine;

public class MapNavigation : MonoBehaviour
{
    public Transform player;

    public Transform hallOfFame;
    public Transform principalBlock;
    public Transform healthCare;
    public Transform swimmingPool;
    public Transform hostel;
    public Transform mess;
    public Transform gym;
    public Transform goKart;
    public Transform horseStable;

    public GameObject mapUI;

    public void GoToLocation(Transform location)
    {
        player.position = location.position;
        mapUI.SetActive(false);
    }
    public void PrincipalBlock()
    {
        GoToLocation(principalBlock);
    }
}