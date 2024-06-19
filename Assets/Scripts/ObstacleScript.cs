using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{

    // New Comments
    public float jumpForce = 2;
    private AudioSource audioSource;

    private void Start()
    {
        // Get the AudioSource component
        audioSource = GetComponent<AudioSource>();

        // Optional: Check if audioSource is assigned
        if (audioSource == null)
        {
            Debug.LogError("AudioSource component is missing from this GameObject.");
        }
    }

        private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Collided");
            if (audioSource != null)
            {
                audioSource.Play();
            }

            Rigidbody goRB = collision.gameObject.GetComponent<Rigidbody>();
            if (goRB != null)
            {
                goRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }


        }
    }
}
