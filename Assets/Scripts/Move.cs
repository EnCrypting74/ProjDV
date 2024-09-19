using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float velocitaMovimento = 5f;
    public float velocitaSterzo = 100f;
    private float angoloSterzo = 0f;

    void Start()
    {
        transform.position = new Vector3(0f, 0.5f, -3f);
    }

    void Update()
    {
        // Movimento sull'asse X (sinistra/destra)
        float movimentoX = Input.GetAxis("Horizontal") * velocitaSterzo * Time.deltaTime;
        angoloSterzo += movimentoX;

        // Rotazione dell'oggetto
        Quaternion rotazione = Quaternion.Euler(0f, angoloSterzo, 0f);
        transform.rotation = rotazione;

        // Movimento sull'asse Z (avanti/indietro)
        float movimentoZ = Input.GetAxis("Vertical") * velocitaMovimento * Time.deltaTime;

        // Calcola la direzione di movimento
        Vector3 direzione = transform.forward * movimentoZ;

        // Calcola la nuova posizione
        Vector3 nuovaPosizione = transform.position + direzione;

        // Assegna la nuova posizione all'oggetto
        transform.position = nuovaPosizione;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("oggetto"))
        {
            collision.transform.SetParent(transform); // Rendi l'oggetto un figlio del player
        }
    }
}
