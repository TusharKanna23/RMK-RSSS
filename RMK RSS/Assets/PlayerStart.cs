using UnityEngine;

public class PlayerStart : MonoBehaviour
{
    public Transform gateStart;

    void Start()
    {
        transform.position = gateStart.position;
    }
}