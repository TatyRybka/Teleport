using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    //Куда телепортироваться:
    public Transform teleportPoint;

    // Игрок входит в телепорт:
    void OnTriggerEnter(Collider other)

    {
        other.transform.position = teleportPoint.position;

    }
}

