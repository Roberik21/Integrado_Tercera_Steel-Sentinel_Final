using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Altar_Destroy_Enemy : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
      {
            // Verifica si el objeto que entra en el trigger tiene la etiqueta "enemy"
            if (other.CompareTag("Enemy"))
            {
                // Destruye el objeto con la etiqueta "enemy"
                Destroy(other.gameObject);
            }
      }
    
}
