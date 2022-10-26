using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerHealth player = other.GetComponent<PlayerHealth>();

        if(player != null)
        {
            player.Crash();
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
