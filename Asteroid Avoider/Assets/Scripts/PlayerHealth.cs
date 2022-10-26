using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] GameOverHandler GameOverHandler;

    public void Crash()
    {
        GameOverHandler.EndGame();

        gameObject.SetActive(false);
    }
}
