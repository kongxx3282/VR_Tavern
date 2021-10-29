using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverReset : MonoBehaviour
{
	private Animator myAnim;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Reseting Animation");
        myAnim = GetComponent<Animator>();
    }

    void Reset()
    {
        myAnim.SetBool("Pulled", false);
    }
}