using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RunScene : MonoBehaviour
{
    // Start is called before the first frame update

    public Button v2;
    public Button v3;
    public Button v4;
    public Button v5;
    public Button v6;
    public Button v7;
    public Button v8;
    public Button v9;
    public Button v10;

    int levelComplete;

    void Start()
    {
        levelComplete = PlayerPrefs.GetInt("LevelComplete");
        v2.interactable = false;
        v3.interactable = false;
        v4.interactable = false;
        v5.interactable = false;
        v6.interactable = false;
        v7.interactable = false;
        v8.interactable = false;
        v9.interactable = false;
        v10.interactable = false;


        switch (levelComplete)
        {
            

            case 1:
                v2.interactable = true;
                break;
            case 2:
                v2.interactable = true;
                v3.interactable = true;
                break;
            case 3:
                v2.interactable = true;
                v3.interactable = true;
                v4.interactable = true;
                break;
            case 4:
                v2.interactable = true;
                v3.interactable = true;
                v4.interactable = true;
                v5.interactable = true;
                break;
            case 5:
                v2.interactable = true;
                v3.interactable = true;
                v4.interactable = true;
                v5.interactable = true;
                v6.interactable = true;
                break;
            case 6:
                v2.interactable = true;
                v3.interactable = true;
                v4.interactable = true;
                v5.interactable = true;
                v6.interactable = true;
                v7.interactable = true;
                break;
            case 7:
                v2.interactable = true;
                v3.interactable = true;
                v4.interactable = true;
                v5.interactable = true;
                v6.interactable = true;
                v7.interactable = true;
                v8.interactable = true;
                break;
            case 8:
                v2.interactable = true;
                v3.interactable = true;
                v4.interactable = true;
                v5.interactable = true;
                v6.interactable = true;
                v7.interactable = true;
                v8.interactable = true;
                v9.interactable = true;

                break;
            case 9:
                v2.interactable = true;
                v3.interactable = true;
                v4.interactable = true;
                v5.interactable = true;
                v6.interactable = true;
                v7.interactable = true;
                v8.interactable = true;
                v9.interactable = true;
                v10.interactable = true;
                break;
        }



    }

    public void LoadTo(int level)
    {
        SceneManager.LoadScene(level);

    }

    public void Reset()
    {
        v2.interactable = false;
        v3.interactable = false;
        v4.interactable = false;
        v5.interactable = false;
        v6.interactable = false;
        v7.interactable = false;
        v8.interactable = false;
        v9.interactable = false;
        v10.interactable = false;
        PlayerPrefs.DeleteAll();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
