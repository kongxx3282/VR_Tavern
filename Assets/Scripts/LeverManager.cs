using OculusSampleFramework;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverManager : MonoBehaviour
{
    public Transform grabbable;
    public Transform slider;
    public Transform grabbableSpawn;
    public enum LeverType
    {
        Altitude,
        Thrust
    };
    public LeverType leverType;
    private bool _isGrabbed;


    // Start is called before the first frame update
    void Start()
    {
    }

    private void LateUpdate()
    {
        _isGrabbed = grabbable.GetComponent<OVRGrabbable>().isGrabbed;

        // if lever is grabbed
        if (_isGrabbed)
        {
            // lever follows controller
            Vector3 target = new Vector3(grabbable.position.x, grabbable.position.y, grabbable.position.z);
            slider.transform.LookAt(target);
            slider.transform.localEulerAngles = new Vector3(slider.transform.localEulerAngles.x, 0, 0);

        }
        else
        {
            grabbable.position = grabbableSpawn.position;
            grabbable.GetComponent<Rigidbody>().velocity = Vector3.zero;
            grabbable.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }


    }

}

