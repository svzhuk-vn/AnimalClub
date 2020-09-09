using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAliens : MonoBehaviour
{

    public Transform SpawnPos;
    public GameObject hole;
    GameObject clone;
    public float spawnSpeed = 5;
    

    // Start is called before the first frame update

    void test()
    {
         clone = GameObject.FindWithTag("hole");
         Destroy(clone, 6f);
        
    }

    void Start()
    {
        StartCoroutine(SpawnCD());
        

    }

    // Update is called once per frame
    void Repeat()
    {
        StartCoroutine(SpawnCD());
        
    }

    IEnumerator SpawnCD()
    {
        yield return new WaitForSeconds(spawnSpeed);
        
        Instantiate(hole, SpawnPos.position, Quaternion.identity);
        Repeat();
    }

    void Update()
    {
        //test();
    }




}
