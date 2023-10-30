using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public int numLlaves = 0;

    public void RecolectarLlave()
    {
        numLlaves++;
        Debug.Log("Has recolectado una llave! Ahora tienes " + numLlaves + " llaves.");
    }

}

