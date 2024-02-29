using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Capture input from the player
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, 10f))
        {
            if(hit.collider.tag == "obstacle")
            {
                Vector3 movement = new Vector3(horizontalInput, 0f, Mathf.Min(verticalInput, 0));

                transform.Translate(movement * moveSpeed * Time.deltaTime);
            }
            
        }
        else
        {
            Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);

            transform.Translate(movement * moveSpeed * Time.deltaTime);
        }
        

    }





}
