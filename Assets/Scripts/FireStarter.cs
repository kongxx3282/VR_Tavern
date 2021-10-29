using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireStarter : MonoBehaviour
{
    public ParticleSystem fire;
    public GameObject light;
    public GameObject lampOne;
    public GameObject lampTwo;
    public GameObject lampThree;
    public GameObject fireOne;
    public GameObject fireTwo;
    public GameObject fireThree;

    // Start is called before the first frame update
    void Start()
    {
        fire.Pause();
        light.SetActive(false);
        lampOne.SetActive(false);
        lampTwo.SetActive(false);
        lampThree.SetActive(false);

        fireOne.SetActive(false);
        fireTwo.SetActive(false);
        fireThree.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider candle) 
    {
    	if (candle.gameObject.tag == "Candle")
    	{
            fire.Play();
            light.SetActive(true);
            lampOne.SetActive(true);
            lampTwo.SetActive(true);
            lampThree.SetActive(true);

            fireOne.SetActive(true);
            fireTwo.SetActive(true);
            fireThree.SetActive(true);
    	}
    	
    }
}
