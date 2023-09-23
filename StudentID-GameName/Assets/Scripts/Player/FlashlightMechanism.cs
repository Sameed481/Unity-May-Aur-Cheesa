using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightMechanism : MonoBehaviour

    
{
    public GameObject flashlight;

    public AudioSource turnOn;
    public AudioSource turnOff;

   
    public bool isFlashlightOn=false;
    // Start is called before the first frame update
    void Start()
    {
        isFlashlightOn = false;
        flashlight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Flashlight"))
        {

            isFlashlightOn = !isFlashlightOn;
            flashlight.SetActive(isFlashlightOn);
        }
    }
}
