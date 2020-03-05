using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightController : MonoBehaviour
{

    public GameObject[] lights;
    // Start is called before the first frame update
    float lightTimer = 0f;
    public float interval = 1f;
    int currentLight = 0;
    // Update is called once per frame
    void Update()
    {
        lightTimer += Time.deltaTime;
        if(lightTimer > interval) {
            lights[currentLight].SetActive(false);
            currentLight++;
            if (currentLight >= lights.Length)
                currentLight = 0;
            lights[currentLight].SetActive(true);
            lightTimer = 0f;
        }
    }
}
