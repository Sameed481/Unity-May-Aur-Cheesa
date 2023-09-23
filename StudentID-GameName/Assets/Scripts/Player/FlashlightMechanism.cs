using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightMechanism : MonoBehaviour


{
    public GameObject flashlight;

    public AudioSource turnOn;
    public AudioSource turnOff;

    public GameObject enemyMovement;


    public bool isFlashlightOn = false;
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

            if (enemyMovement!=null) {
                int childCount = enemyMovement.transform.childCount;
                for (int i = 0; i < childCount; i++) {
                    Transform child = enemyMovement.transform.GetChild(i);
                    if (child.TryGetComponent<EnemyMovement>(out var enemy)){
                        if (isFlashlightOn == true)
                            enemy.sightRange += 10f;
                        else
                            enemy.sightRange -= 10f;
                    
                    }
                }
                
            }
           
        }
        
    }
}
