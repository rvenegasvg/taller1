using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salida : MonoBehaviour
{
    public GameObject gameObject;
    private void OnTriggerEnter(Collider other)
    {
        if(other.name=="Player")
            gameObject.SetActive(true);
    }
}
