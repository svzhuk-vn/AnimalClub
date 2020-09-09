using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCarrot : MonoBehaviour
{

    public Transform[] carrot;
    //public bool gen=true;
    // Start is called before the first frame update
    void Start()
    {
        StartGenerate();
    }

    void StartGenerate()  //рандомна генерація hole знизу
    { 
        //if (gen==false)
        {
            for (int i=0; i < carrot.Length; i++)
            {
                Vector2 px1, px2, h;
                px1 = new Vector2(-5.8f, 1);
                px2 = new Vector2(5.8f, 1);
                h = new Vector2(Random.Range(px1.x, px2.x), carrot[i].position.y);

                // + Random.Range(-1f, 1f)
                carrot[i].position = h;
                //hole[i].transform.position = new Vector2(hole[i].transform.position.x, hole[i].transform.position.y * Time.deltaTime);
            
            }
        }
    }

    // Update is called once per frame
    /*void Update()
    {
        for (int i = 0; i < hole.Length; i++)
        {
            
            hole[i].transform.Translate(new Vector2(0, 1) * Time.deltaTime); 

        } 
    }*/
}
