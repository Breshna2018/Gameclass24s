using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class code : MonoBehaviour


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
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardinput);
        transform.Rotate(Vector3.up, turnspeed * horizontalinput * Time.deltaTime);

    } // Update

    private void OnTriggerEnter(Collider other)
    {
        string objectTag = other.tag;

        string positiveTagName = "BoxPositive";
        string negativeTagName = "BoxNegative";

        if(objectTag == positiveTagName)
        {
            Debug.Log("This is a positive box");

            // To make an object disappear, call Destory(object)
            Destroy(other.gameObject);
        }
        else if(objectTag == negativeTagName) {
            Debug.Log("This is a negative box");
        }
    }


} // code.cs
