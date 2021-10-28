using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPadButton : MonoBehaviour
{
    public int buttonId;
    private AudioSource audioSource;
    public KeyPadData data;
    private bool correctCode = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger)) 
        {
            if (buttonId == 1) {data.firstNum = (data.firstNum + 1)%10;}
            else if (buttonId == 2) {data.secondNum = (data.secondNum + 1)%10;}
            else if (buttonId == 3) {data.thirdNum = (data.thirdNum + 1)%10;}
            else if (buttonId == 4) {data.fourthNum = (data.fourthNum + 1)%10;}
            else if (buttonId == 5) 
            {
                if (data.firstNum == data.solution[0] && data.secondNum == data.solution[1] && data.thirdNum == data.solution[2] && data.fourthNum == data.solution[3])
                {
                    correctCode = true;
                }
            }
        }
    }
}
