using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisione : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("oggetto"))
        {
            collision.transform.SetParent(transform); // Rendi l'oggetto un figlio del player
        }
    }
}
