using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
    public Text clock;
    public Text points;
    private float timeLeft;
    private string Letter;
    private int a;
    private int point;
    public SpriteChanger spriteChanger;
    public LevelManager levelManager;
    int i = 0;
    // Use this for initialization
    void Start () {
        RandLetter();
        timeLeft = 1.5f;
        clock.text = timeLeft.ToString();
        points.text = "0";
        point = 0;      
    }
	
	// Update is called once per frame
	void Update () {                                    //<------------------UPDATEE!
        Timer();
        CheckAnswer();
          if (timeLeft<0)
          {
            levelManager.LoadLevel("Lose Scene");    
          }
          
        
    }


    public void CorrectAnswer()
    {
        point++;
        points.text = point.ToString();
        RandLetter();
        //point and time
    }

    public void CheckAnswer()
    {
        switch (a)
        {
            case 1:
                if (Input.GetKeyDown(KeyCode.W))
                    CorrectAnswer();
                break;
            case 2:
                if (Input.GetKeyDown(KeyCode.A))
                    CorrectAnswer();
                break;
            case 3:
                if (Input.GetKeyDown(KeyCode.S))
                    CorrectAnswer();
                break;
            case 4:
                if (Input.GetKeyDown(KeyCode.D))
                    CorrectAnswer();
                break;

        }
    }

    public void Timer()
    {
        timeLeft -= Time.deltaTime;
        clock.text = timeLeft.ToString();
        if (timeLeft < 0.7)
        {
            spriteChanger.ButtonColorRed();
        }
    }
    public void RandLetter()
    {
        
        a=Random.Range(1, 5);
        switch (a)
        {
            case 1:
                Letter = "W";
                break;
            case 2:
                Letter = "A";
                break;
            case 3:
                Letter = "S";
                break;
            case 4:
                Letter = "D";
                break;
        }
        spriteChanger.ButtonColorBlack();
        spriteChanger.ButtonChange(a);
        timeLeft = 1.5f;
    }
}
