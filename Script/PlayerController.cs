using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    public TextMeshProUGUI countText;
    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
    }

    void OnMove(InputValue movementvalue)
    {
        //Function body
        Vector2 movementVector = movementvalue.Get<Vector2>();
        Debug.Log("Move: " + movementVector);

        movementX = movementVector.x;
        movementY = movementVector.y;

    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
       rb.AddForce(movement * speed);
    }

     void OnTriggerEnter(Collider other) 
    {
 // Check if the object the player collided with has the "PickUp" tag.
        if (other.gameObject.CompareTag("PickUp")) 
        {
 // Deactivate the collided object (making it disappear).
            other.gameObject.SetActive(false);
        // Increment the count of collected items.
            count = count + 1;
            Debug.Log("Count: " + count);
        // Update the count display on the UI.
            SetCountText();
        }
    }
}
