using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Respawn : MonoBehaviour {

    [SerializeField] private Transform player;
    [SerializeField] private Transform Spawn;
    private void OnTriggerEnter(Collider other)
    {
        
        player.transform.position = Spawn.transform.position;
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

