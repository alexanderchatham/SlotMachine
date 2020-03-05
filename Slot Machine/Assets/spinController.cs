using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class spinController : MonoBehaviour
{
    public GameObject[] wheels;
    public float[] rotationSpeed;
    public float[] rotationTime;
    public float minTime = 3f;
    public float maxTime = 8f;
    public float minSpeed = .5f;
    public float maxSpeed = 1f;

    public bool spinning;
    public UnityEvent invokeMethod;
 
    // Start is called before the first frame update
    void Start()
    {
        initialSpeeds();
        invokeMethod.Invoke();
    }

    void initialSpeeds()
    {
        if (wheels.Length > 0)
        {
            
            
            rotationSpeed = new float[wheels.Length];
            rotationTime = new float[wheels.Length];
            
            for (int i = 0; i < wheels.Length; i++)
            {
                rotationSpeed[i] = Random.Range(minSpeed, maxSpeed);
                rotationTime[i] = Random.Range(minTime, maxTime);

            }
        }
    }

    public void startSpin()
    {
        spinning = true;
    }
    float spinDampen = 0;

    // Update is called once per frame
    void Update()
    {
        if (spinning)
        {
        spinning = false;
            for (int i = 0; i < wheels.Length; i++)
            {
                if (rotationTime[i] > 0f)
                {
                    spinning = true;
                    if (rotationTime[i] > 1f)
                    {
                        wheels[i].transform.Rotate(Vector3.up * rotationSpeed[i] * spinDampen);
                    }
                    else
                    {
                        wheels[i].transform.Rotate(Vector3.up * rotationSpeed[i] * rotationTime[i]);
                    }
                    rotationTime[i] -= Time.deltaTime;
                }
            }
            if (spinDampen < 1f)
            {
                spinDampen += .01f;
            }

            if (!spinning)
            {
                initialSpeeds();
            }
        }
    }
}
