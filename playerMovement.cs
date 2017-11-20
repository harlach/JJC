using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {
    public Transform playerModel;
    public float movementSpeed;

	// Use this for initialization
	void Start () {
        movementSpeed = 10;
	}
	
	// Update is called once per frame
	void Update () {
      // playerModel.Translate(x:movementSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, y: 0f, z:movementSpeed * Input.GetAxis("Vertical") * Time.deltaTime);

        if (Input.GetKey("a"))
        {
            playerModel.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            playerModel.Translate(Vector3.forward * movementSpeed * Time.deltaTime);

        }

        if (Input.GetKey("w"))
        {
            playerModel.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            playerModel.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        }
	}
}
