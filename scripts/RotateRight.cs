using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRight : MonoBehaviour
{
    // Start is called before the first frame update

    bool isPressed;

    public void StartRotate()
    {
        isPressed = true;
    }

    public void FinishRotate()
    {
        isPressed = false;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isPressed)
        {
            transform.Rotate(new Vector3(0, 0, -50) * Time.deltaTime);

        }

    }
}
