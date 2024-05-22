using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxAnimation : MonoBehaviour
{

    public float maxY = 2;
    public float minY = 0;
    public float speed = .2f;
    public bool goingUp;

    public float rotationY = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.y > maxY)
        {
            speed *= -1;
        }
        else if (transform.position.y < minY)
        {
            speed *= -1;

        }

        transform.Rotate(new Vector3(0, rotationY * Time.deltaTime, 0));
        transform.Translate(0, transform.position.y * speed * Time.deltaTime, 0);
    }
}
