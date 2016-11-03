using UnityEngine;
using System.Collections;
using VRStandardAssets.Utils;

public class ChangeDimension : MonoBehaviour {
    VRInput inputController;
    Camera thisCam;
    public LayerMask[] dimensions;
    int i = 0;
    // Use this for initialization
    void Start ()
    {
        inputController = GetComponent<VRInput>();
        thisCam = GetComponent<Camera>();
        thisCam.cullingMask = dimensions[i];
        inputController.OnClick += InputController_OnClick;
	}

    private void InputController_OnClick()
    {
        //change dimension (culling Mask)
        i = (2 + i) % 3;
        thisCam.cullingMask = dimensions[i];
        Debug.Log("Culling Mask = " + i);

    }

    // Update is called once per frame
    void Update () {
	
	}
}
