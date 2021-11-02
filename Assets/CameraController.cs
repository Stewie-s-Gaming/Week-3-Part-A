using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{        

    private Vector3 offset;


    void Start()
    {
        offset = transform.position - GameObject.Find("Mover").transform.position;
    }

    void Update()
    {
        transform.position = GameObject.Find("Mover").transform.position+ offset;
    }
}
