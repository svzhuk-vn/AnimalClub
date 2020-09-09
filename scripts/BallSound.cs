using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSound : MonoBehaviour
{
    public AudioSource eat;
    public AudioSource die;
    void OnCollisionEnter2D(Collision2D coll) // знищення моркви гравцем
    {
        if (coll.gameObject.tag == "food")
        {
                    
           eat.Play();
            
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {


        if (coll.gameObject.tag == "hole")
        { die.Play(); }

        if (coll.gameObject.tag == "destroyer")
        { die.Play(); }
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
