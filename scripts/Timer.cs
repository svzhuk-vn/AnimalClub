using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text counterText;
    public Text counterText2;
    //GameObject[] hole;
    float counter;
    public float difficult = 10;
    

   
    void countZero()
    {
        EatIt.count = 0;
    }

    void Start()
    {

        counterText2.text = "/ " + difficult.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //hole = GameObject.FindGameObjectsWithTag("hole");
        //counter = hole.Length;
        counter = EatIt.count;
        //print(counter);
        counterText.text = counter.ToString();

        if (counter == difficult)
        {
            Save.instance.isEndGame();
            Invoke("countZero", 1f);

            // SceneManager.LoadScene("MainMenu"); !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            //eatit.count = 0; 
            //restart.ReStart();

        }

        

    }

}

