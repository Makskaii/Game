using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPoint;

    void OnTriggerStay(Collider other)
    {
        other.transform.position = teleportPoint.transform.position;
    }
}
