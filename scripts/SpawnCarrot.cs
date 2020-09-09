using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCarrot : MonoBehaviour
{

    public Transform SpawnPos;
    public GameObject hole;
    public float speedFood = 5;
    public AudioSource coin;
    // Start is called before the first frame update



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
        yield return new WaitForSeconds(speedFood);
        coin.Play();
        Instantiate(hole, SpawnPos.position, Quaternion.identity);
        
        Repeat();
    }

    void Update()
    {
       
    }




}
