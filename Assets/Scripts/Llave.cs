using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Llave : MonoBehaviour
{

    public int numLlaves = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            numLlaves++;
            Debug.Log("Has recolectado una llave! Ahora tienes " + numLlaves + " llaves.");
            Destroy(gameObject);
        }
    }
}
