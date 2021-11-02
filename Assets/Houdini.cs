using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Houdini : MonoBehaviour
{
    bool flag;
    // Start is called before the first frame update
    void Start()
    {
        flag = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (flag)
            {
                this.GetComponent<Renderer>().enabled = false;
                flag = false;
            }
            else
            {
                this.GetComponent<Renderer>().enabled = true;
                flag = true;
            }
        }
    }
}
