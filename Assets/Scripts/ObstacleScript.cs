using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{


    public float jumpForce = 2;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Collided");

            Rigidbody goRB = collision.gameObject.GetComponent<Rigidbody>();
            if (goRB != null)
            {
                goRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }


        }
    }
}
