using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAlpa : MonoBehaviour {

	// public float alphaLevel = 0.2f;
	GameObject prefab;
	bool status = false;
	// Use this for initialization
	void Start () {
		// GetComponent<Renderer>().material.color = new Color(1, 1, 1, alphaLevel);
		GetComponent<MeshRenderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		// GetComponent<Renderer>().material.color = new Color(1, 1, 1, getAlphaLevel());
		GetComponent<MeshRenderer>().enabled = getMeshrender();
	}

	public void setMeshrender(bool render) {
		GetComponent<MeshRenderer>().enabled = render;
	}

	public bool getMeshrender(){
		return status;
	}

}
