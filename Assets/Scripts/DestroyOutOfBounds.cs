using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    float zBound = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > zBound || transform.position.z < -zBound)
        {
            Destroy(gameObject);
        }
    }
}
