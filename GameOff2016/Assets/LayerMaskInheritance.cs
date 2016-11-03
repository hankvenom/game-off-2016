using UnityEngine;
using System.Collections;

public class LayerMaskInheritance : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Transform[] ts = gameObject.GetComponentsInChildren<Transform>();

        foreach (var child in ts)
            child.gameObject.layer=gameObject.layer;
	}
	
}
