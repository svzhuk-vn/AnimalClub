using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{



    public static void ReStart()
    {
        string scene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(scene);
        EatIt.count = 0;
    }

    public void ReStart2()
    {
        string scene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("MainMenu");
        EatIt.count = 0;
    }



}