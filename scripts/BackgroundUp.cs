using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundUp : MonoBehaviour
{
    //public float speed = 0.1f;
    private Vector2 offset = Vector2.zero;
    private Material mat;
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
        offset = mat.GetTextureOffset("_MainTex");
    }

    // Update is called once per frame
    void Update()
    {
        offset.y -= Time.deltaTime * 0.1f; //  speed * 
        mat.SetTextureOffset("_MainTex", offset);
    }
}
