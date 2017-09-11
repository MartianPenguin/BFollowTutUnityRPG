using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour {

    public LayerMask movemntmask;

    PlayerMotor motor;
    Camera cam;

	// Use this for initialization
	void Start () {
        motor = GetComponent<PlayerMotor>();
        cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, 100f, movemntmask))
            {
                //Move our player to what we hit
                motor.MoveToPoint(hit.point);

                //Stop focus any target
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100f))
            {
                //See if we hit an interacteble
                //If so set it as focus
            }
        }

    }
}
