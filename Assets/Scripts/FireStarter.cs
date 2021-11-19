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
    public GameObject bakedScene;
    public GameObject unbakedScene;

    // Start is called before the first frame update
    void Start()
    {
        fire.Pause();
        bakedScene.SetActive(false);
        unbakedScene.SetActive(true);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider candle) 
    {
    	if (candle.gameObject.tag == "Candle")
    	{
            unbakedScene.SetActive(false);
            bakedScene.SetActive(true);
            
    	}
    	
    }
}
