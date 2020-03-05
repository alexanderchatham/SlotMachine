using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hitController : MonoBehaviour
{
    public winningController winning;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hit");

        if (collision.gameObject.tag == "Wheel1")
        {
            winning.setCard(collision.gameObject.GetComponent<Image>().sprite, 0);
        }

        if (collision.gameObject.tag == "Wheel2")
        {
            winning.setCard(collision.gameObject.GetComponent<Image>().sprite, 1);
        }

        if (collision.gameObject.tag == "Wheel3")
        {
            winning.setCard(collision.gameObject.GetComponent<Image>().sprite, 2);
        }
    }


}
