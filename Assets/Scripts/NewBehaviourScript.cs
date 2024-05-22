using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject camer;
    private Vector3 offset = new Vector3(0, 5, -7);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = camer.transform.position + offset;
    }
}
