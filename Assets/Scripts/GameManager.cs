using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public int numLlaves = 0;
    public GameObject objetoAMover;

    public void RecolectarLlave()
    {
        numLlaves++;

        if (numLlaves == 3)
        {
            objetoAMover.transform.Translate(0, 5, 0);
        }

        Debug.Log("Has recolectado una llave! Ahora tienes " + numLlaves + " llaves.");

    }
}

