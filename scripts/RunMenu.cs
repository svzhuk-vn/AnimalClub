using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void b1()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void exit()

    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
