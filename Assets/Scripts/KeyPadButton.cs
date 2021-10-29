using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPadButton : MonoBehaviour
{
    public KeyPadData data;
    private bool correctCode = false;

    public GameObject wheelOne;
    public GameObject wheelTwo;
    public GameObject wheelThree;
    public GameObject wheelFour;
    public Animator lever;
    public GameObject popUp;

    // Start is called before the first frame update
    void Start()
    {
        data.firstNum = 0;
        data.secondNum = 0;
        data.thirdNum = 0;
        data.fourthNum = 0;

        popUp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (OVRInput.GetDown(OVRInput.RawButton.Y)) {
            wheelOne.transform.Rotate(0.0f, 0.0f, -36.0f);
            data.firstNum = (data.firstNum + 1) % 10;
        }
        else if (OVRInput.GetDown(OVRInput.RawButton.X)) {
            wheelTwo.transform.Rotate(0.0f, 0.0f, -36.0f);
            data.secondNum = (data.secondNum + 1) % 10;
        }
        else if (OVRInput.GetDown(OVRInput.RawButton.B)) {
            wheelThree.transform.Rotate(0.0f, 0.0f, -36.0f);
            data.thirdNum = (data.thirdNum + 1) % 10;
        }
        else if (OVRInput.GetDown(OVRInput.RawButton.A)) {
            wheelFour.transform.Rotate(0.0f, 0.0f, -36.0f);
            data.fourthNum = (data.fourthNum + 1) % 10;
        }
        else if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger)) {lever.SetBool("Pulled", true);}

        
        if (data.firstNum == data.solution[0] && data.secondNum == data.solution[1] && data.thirdNum == data.solution[2] && data.fourthNum == data.solution[3])
        {
            correctCode = true;
        }

        if (correctCode && lever.GetBool("Pulled")) 
        {
            popUp.SetActive(true);
        }

    }
}
