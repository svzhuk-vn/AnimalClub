using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EatIt : MonoBehaviour
{
    public static  float count = 0;
    
    


    void OnCollisionEnter2D (Collision2D coll) // знищення моркви гравцем
    {
        if (coll.gameObject.tag == "Player")
        {
            //Destroy(GameObject.FindWithTag("food"));
            
            Destroy(gameObject);
            
            count++;
            

            //Debug.Log(count);
        }
    }


    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "destroyer")
        {
            Destroy(gameObject);
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
