using UnityEngine;

public class MapTeleport : MonoBehaviour
{
    public Transform player;

    public Transform gate;
    public Transform principalBlock;
    public Transform hallOfFame;
    public Transform healthCare;
    public Transform hostel;
    public Transform diningHall;
    public Transform gym;
    public Transform goKart;
    public Transform stable;
    public Transform swimmingPool;   // NEW LOCATION

    public void GoGate()
    {
        player.position = gate.position;
    }

    public void GoPrincipalBlock()
    {
        player.position = principalBlock.position;
    }

    public void GoHallOfFame()
    {
        player.position = hallOfFame.position;
    }

    public void GoHealthCare()
    {
        player.position = healthCare.position;
    }

    public void GoHostel()
    {
        player.position = hostel.position;
    }

    public void GoDiningHall()
    {
        player.position = diningHall.position;
    }

    public void GoGym()
    {
        player.position = gym.position;
    }

    public void GoGoKart()
    {
        player.position = goKart.position;
    }

    public void GoStable()
    {
        player.position = stable.position;
    }

    public void GoSwimmingPool()   // NEW FUNCTION
    {
        player.position = swimmingPool.position;
    }
}