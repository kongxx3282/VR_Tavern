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
    public GameObject lever;

    // Start is called before the first frame update
    void Start()
    {
        data.firstNum = 0;
        data.secondNum = 0;
        data.thirdNum = 0;
        data.fourthNum = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (OVRInput.GetDown(OVRInput.RawButton.Y)) {wheelOne.transform.Rotate(0.0f, 0.0f, -36.0f);}
        else if (OVRInput.GetDown(OVRInput.RawButton.X)) {wheelTwo.transform.Rotate(0.0f, 0.0f, -36.0f);}
        else if (OVRInput.GetDown(OVRInput.RawButton.B)) {wheelThree.transform.Rotate(0.0f, 0.0f, -36.0f);}
        else if (OVRInput.GetDown(OVRInput.RawButton.A)) {wheelFour.transform.Rotate(0.0f, 0.0f, -36.0f);}
        

        data.firstNum = -(int)wheelOne.transform.localRotation.eulerAngles.z / 36;
        data.secondNum = -(int)wheelTwo.transform.localRotation.eulerAngles.z / 36;
        data.thirdNum = -(int)wheelThree.transform.localRotation.eulerAngles.z / 36;
        data.fourthNum = -(int)wheelFour.transform.localRotation.eulerAngles.z / 36;

        Debug.Log(data.firstNum);

        // Console.Log(data.firstNum);
        
        if (data.firstNum == data.solution[0] && data.secondNum == data.solution[1] && data.thirdNum == data.solution[2] && data.fourthNum == data.solution[3])
        {
            correctCode = true;
        }
    }
}
