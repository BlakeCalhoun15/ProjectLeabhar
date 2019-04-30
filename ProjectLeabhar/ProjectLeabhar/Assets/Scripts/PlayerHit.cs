using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("breakable"))
        {
            collider.GetComponent<Pot>().Destroy();
        }
        else if (collider.CompareTag("enemy"))
        {
            collider.GetComponent<Slime>().health -= 1;
        }
    }
}
