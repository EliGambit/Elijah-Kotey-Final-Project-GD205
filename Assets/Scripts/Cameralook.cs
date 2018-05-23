using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameralook : MonoBehaviour {

	public Transform playerBody;
	public float mouseSensitvity;

	float xAxisClamp = 0.0f;

	private void Awake()
	{
		Cursor.lockState = CursorLockMode.Locked;
	}

	// Update is called once per frame
	void Update () {
		RotateCamera();

	}
	void RotateCamera()
	{
		float mouseX = Input.GetAxis("Mouse X");
		float mouseY = Input.GetAxis("Mouse Y");

		float rotAmountX = mouseX * mouseSensitvity;
		float rotAmountY = mouseY * mouseSensitvity;

		xAxisClamp += rotAmountY;

		Vector3 targetRotCam = transform.rotation.eulerAngles;
		Vector3 targetRotBody = playerBody.rotation.eulerAngles;

		xAxisClamp -= rotAmountY;

		targetRotCam.x -= rotAmountY;
		targetRotCam.z = 0;
		targetRotBody.y += rotAmountX;

		if(xAxisClamp > 90)
		{
			xAxisClamp =  90;
			targetRotCam.x = 90;
		}
		else if(xAxisClamp < -90) {
			xAxisClamp = -90;
			targetRotCam.x = 270;
		}


		transform.rotation = Quaternion.Euler(targetRotCam);
		playerBody.rotation = Quaternion.Euler(targetRotBody);
	}
}