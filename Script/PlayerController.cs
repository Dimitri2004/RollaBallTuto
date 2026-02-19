using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    public TextMeshProUGUI countText;
    public TextMeshProUGUI winTextObject;

    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;
    private int totalPickUps;

    void Start()
        {
        rb = GetComponent<Rigidbody>();
        count = 0;

        // 1. Contamos cuántos PickUps hay en la escena al iniciar
        totalPickUps = GameObject.FindGameObjectsWithTag("PickUp").Length;

        // 2. Ocultamos el mensaje de "Ganaste/Perdiste" al empezar
        if (winTextObject != null)
        {
            winTextObject.gameObject.SetActive(false);
        }

        SetCountText();
    }

    void OnMove(InputValue movementvalue)
    {
        Vector2 movementVector = movementvalue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        // 3. CONDICIÓN DE VICTORIA: Si recolectaste todos
        if (totalPickUps > 0 && count >= totalPickUps)
        {
            if (winTextObject != null)
            {
                winTextObject.gameObject.SetActive(true);
                winTextObject.text = "¡Has Ganado!";
            }
        }
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (winTextObject != null)
            {
                winTextObject.gameObject.SetActive(true);
                winTextObject.text = "You Lose!";
            }
            else 
            {
                Debug.LogError("Asigna el winTextObject en el Inspector.");
            }

            // Destruimos al jugador (Ojo: esto causará el error en la cámara 
            // si no pusiste el 'if (target != null)' que vimos antes)
            Destroy(gameObject); 
        }
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("PickUp")) 
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }
}