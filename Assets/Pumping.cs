using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumping : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The size the pulse increases each time.")]
    float steps = 0.01f;
    float rescaleFactor = 0.01f;

    [SerializeField]
    [Tooltip("The maximum size of the pulsing.")]
    float limit = 0.2f;
    Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }

    // Update is called once per frame
    void Update()
    {
            if (rescaleFactor > 0f)
            {
                transform.localScale = new Vector3(transform.localScale.x + rescaleFactor*Time.deltaTime, transform.localScale.y + rescaleFactor * Time.deltaTime, transform.localScale.z);
                rescaleFactor += steps;
                    if (transform.localScale.x>=limit+startPosition.x) rescaleFactor = -steps;
            }
            else
            {
                transform.localScale = new Vector3(transform.localScale.x + rescaleFactor * Time.deltaTime, transform.localScale.y + rescaleFactor * Time.deltaTime, transform.localScale.z);
                rescaleFactor -= steps;
                if (transform.localScale.x <=startPosition.x) rescaleFactor = steps;
            }
    }
}
