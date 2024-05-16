using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Altar_Destroy_Enemy : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Objeto entró en el trigger");
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Enemy detectado y destruido");
            Destroy(other.gameObject);
        }
    }
}
    

