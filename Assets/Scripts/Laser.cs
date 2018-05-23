using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {
    public GameObject prefab;// creates a slot for the game object being used for the raycast, but it is not the source of the raycast
 
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {

        Ray beam = Camera.main.ScreenPointToRay(Input.mousePosition);// The ray beam uses the main camera as a source. The ray uses the mouse as a controller

        Debug.DrawRay(beam.origin, beam.direction * 1000f);// from the source of the beam, shoot out a ray by the desired length or range

        RaycastHit beamHit = new RaycastHit();// created a function to signal when the ray has hit something on the scree.

        if (Physics.Raycast(beam, out beamHit, 1000f))// if the beam is in range of target
        {
            if (Input.GetMouseButtonDown(0))// if the mouse is left clicked (represented by 0)
            {
             
                if (beamHit.rigidbody != null)// if the beam is pointed in a direction
                {
                    beamHit.rigidbody.AddForce(Random.insideUnitSphere * 10000f);// The range of the beam
                }
                transform.LookAt(beamHit.point);//Transforms the position of the player to change the direction they are facing
            }
            if (Input.GetMouseButtonDown(1))// if the mouse is right clicked (represented by 1)
            {
                Instantiate(prefab, beamHit.point, Quaternion.identity);//create the game object declared in the "prefab" slot in the game
            }
            if (Input.GetMouseButtonDown(2))// if the mouse is middle clicked (represented by 2)
            {
                Destroy(beamHit.collider.gameObject);// destroy the game object hit by the beam ray
            }
        }

    }
}