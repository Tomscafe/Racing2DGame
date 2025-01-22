using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            PlayerController.playerGas += 30;
        }
    }
}
