using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{

    // New Comments
    public float jumpForce = 2;
    private AudioSource audioSource;
    private Renderer renderer;
    public Color newColor = Color.red;



    private void Start()
    {
        // Get the AudioSource component
        audioSource = GetComponent<AudioSource>();
        renderer = GetComponent<Renderer>();

        // Optional: Check if audioSource is assigned
        if (audioSource == null)
        {
            Debug.LogError("AudioSource component is missing from this GameObject.");
        }
        if (renderer == null)
        {

            Debug.LogError("Renderer component is missing ");
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
                Debug.Log("Audio Source should play");
            }
            if (renderer != null)
            {
                renderer.material.color = newColor;
            }

            Rigidbody goRB = collision.gameObject.GetComponent<Rigidbody>();
            if (goRB != null)
            {
                goRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                if(jumpForce > 4)
                {
                    Time.timeScale = 0;
                    if (audioSource.isPlaying)
                    {

                        audioSource.Stop();
                    }
                    Debug.Log("game stoped");
                }
            }


        }
    }
}
