using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="KeyPadData")]
public class KeyPadData : ScriptableObject
{
    public int[] solution = new int[] { 3, 8, 5, 2 };
    public float firstNum = 0;
    public float secondNum = 0;
    public int thirdNum = 0;
    public int fourthNum = 0;

}
