using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerText : MonoBehaviour {

	public void showText() {
		if (GetComponent<MeshRenderer>().enabled == false)
			GetComponent<MeshRenderer>().enabled = true;
		else {
			GetComponent<MeshRenderer>().enabled = false;
		}
	}

}
