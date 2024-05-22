using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carcode : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnspeed = 40.0f;
    private float horizontalinput;
    private float forwardinput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalinput = Input.GetAxis("Horizontal");
        forwardinput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardinput);
        transform.Rotate(Vector3.up, turnspeed*horizontalinput*Time.deltaTime);
        
    } // Update

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided");
    }

    // Event Methods - OnTrigger
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided With Something");
    }


} // carcode
