using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Piano : MonoBehaviour
{
    
    public float randMax = 10f;
    public float randMin = 60f;
    
    void Start()
    {
        transform.position = new Vector3(
            Random.Range(randMin, randMax),
            0.1f,
            Random.Range(randMin, randMax)
            );
    }

    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("oggetto"))
        {   
            SceneManager.LoadScene("SampleScene");
        }   
    }
    
}
