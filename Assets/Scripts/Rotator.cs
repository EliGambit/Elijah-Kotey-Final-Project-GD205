using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    void Update()// Update is called once per frame
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);// transform the X,Y, and Z rotation of the object based on the time it takes to go through one frame
    }
}