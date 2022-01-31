/*
 * (Luke Hensley)
 * (Challenge 1)
 * (Controls propeller movement)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{

    public int rotation;
  
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotation * Time.deltaTime);
    }
}
