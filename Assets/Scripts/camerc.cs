using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerc : MonoBehaviour
{
    public GameObject camera;
    public float x = 14.5f;
    public float y = 9.66f;
    public float z = 5.18f;

    private Vector3  offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector3(x, y, z);


        camera.transform.position = transform.position + offset;
    }
}
