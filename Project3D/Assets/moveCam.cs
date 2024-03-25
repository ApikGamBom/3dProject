using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCam : MonoBehaviour
{
    public bool mRight = true;
    public float camSpeed = 20;
    public float lBarrier = 500;
    public float rBarrier = 300;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (mRight && pos.x > rBarrier)
        {
            pos.x -= camSpeed * Time.deltaTime;
            transform.position = pos;
        }
        else if (pos.x <= rBarrier && mRight)
        {
            mRight = false;
        }
        else if (mRight == false && pos.x < lBarrier)
        {
        pos.x += camSpeed * Time.deltaTime;
        transform.position = pos;
        }
        else if (pos.x >= lBarrier && mRight == false)
        {
            mRight = true;
        }
    }
}