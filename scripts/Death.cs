using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    

    

    public void restartPlus() {
        Restart.ReStart();
    }


    void OnTriggerEnter2D(Collider2D coll)
    {
       
        
        if (coll.gameObject.tag == "Player")
        { 
        Destroy(GameObject.FindWithTag("Player"));
                        
         
            Invoke("restartPlus", 1f);
        }



       
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
