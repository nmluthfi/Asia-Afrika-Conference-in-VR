using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectObject : MonoBehaviour {

	// Use this for initialization
	
	public GameObject gameObject;
	ChangeAlpa changeAlpa;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, 10)) {
            changeAlpa.setMeshrender(true);
			// Debug.Log("Ada object didepan");
		}
    }

}
