using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChanger : MonoBehaviour {
    public Sprite[] ButtonsSprites;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    public void ButtonChange(int a)
    {
        switch (a)
        {
            case 1:
                    this.GetComponent<Image>().sprite = ButtonsSprites[10];
                break;
            case 2:
                    this.GetComponent<Image>().sprite = ButtonsSprites[1];
                break;
            case 3:
                    this.GetComponent<Image>().sprite = ButtonsSprites[7];
                break;
            case 4:
                    this.GetComponent<Image>().sprite = ButtonsSprites[4];
                break;

        }
    }

    public void ButtonColorRed()
    {
        this.GetComponent<Image>().color = Color.red;
    }

    public void ButtonColorBlack()
    {
        this.GetComponent<Image>().color = Color.white;
    }
    
}
