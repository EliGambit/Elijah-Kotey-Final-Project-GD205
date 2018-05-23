
using UnityEngine;

public class Look : MonoBehaviour {
    public Transform player;// creates a slot to follow whatever is declared in the slot
    public Vector3 offset;// changes the X,Y, and Z position of whatever the script is attached to based on it's current position
	
	
	// Update is called once per frame
	void Update () {
        transform.position = player.position + offset;//transform the position of the object with this script to the position of the player. The offset is for additional positioning.
	}
}
