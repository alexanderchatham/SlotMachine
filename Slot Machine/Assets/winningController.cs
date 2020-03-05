using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class winningController : MonoBehaviour
{
    public Image[] winningCards;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void setCard(Sprite image, int card)
    {
        winningCards[card].sprite = image;
    }
}
