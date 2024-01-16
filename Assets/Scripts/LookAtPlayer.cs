using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    public Transform player;
    public Canvas canvas;

    // Update is called once per frame
    void Update()
    {
        // Check if the player reference is set
        if (player != null)
        {
            // Calculate the direction from the current object to the player
            Vector3 directionToPlayer = player.position - transform.position;

            // Use Quaternion.LookRotation to smoothly rotate the object towards the player
            Quaternion rotationToPlayer = Quaternion.LookRotation(directionToPlayer);

            rotationToPlayer *= Quaternion.Euler(0, 180f, 0);
            // Apply the rotation to the object
            transform.rotation = rotationToPlayer;

            // Adjust Canvas rotation if Canvas is in World Space
            if (canvas.renderMode == RenderMode.WorldSpace)
            {
                Vector3 canvasForward = rotationToPlayer * Vector3.forward;
                Vector3 canvasUp = rotationToPlayer * Vector3.up;
                canvas.transform.rotation = Quaternion.LookRotation(canvasForward, canvasUp);
            }
        }
        else
        {
            Debug.LogWarning("Player reference not set. Please assign the player GameObject.");
        }
    }
}
