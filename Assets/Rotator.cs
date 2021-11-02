using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Step size")]
    float step_size;
    float step_init = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        step_size = step_init;
    }

    // Update is called once per frame
    void Update()
    {
        var rotationVector = transform.rotation.eulerAngles;
        if (!Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            rotationVector.z -= step_size;
            transform.rotation = Quaternion.Euler(rotationVector);

        }
        else if (Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))
        {
            rotationVector.z += step_size;
            transform.rotation = Quaternion.Euler(rotationVector);
        }
    }
}
