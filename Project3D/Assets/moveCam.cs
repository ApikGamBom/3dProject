using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public class moveCam : MonoBehaviour
// {
//     public Camera cam;
//     public bool mRight;
//     public float camSpeed = 20;
//     public float lBarrier = 500;                  
//     public float rBarrier = 300;
//     // Start is called before the first frame update

//     // Update is called once per frame
//     void Update()
//     {
//         // Vector3 pos = transform.position;
//         // if (mRight && pos.x > rBarrier)
//         // {
//         //     pos.x -= camSpeed * Time.deltaTime;
//         //     transform.position = pos;
//         // }
//         // else if (pos.x <= rBarrier && mRight)
//         // {
//         //     mRight = false;
//         // }
//         // else if (mRight == false && pos.x < lBarrier)
//         // {
//         // pos.x += camSpeed * Time.deltaTime;
//         // transform.position = pos;
//         // }
//         // else if (pos.x >= lBarrier && mRight == false)
//         // {
//         //     mRight = true;
//         // }
//         cam.transform.position = new Vector3();
//         cam.transform.Rotate(new Vector3(1, 0, 0), direction.y * 80);
//         cam.transform.Translate(new Vector3(0, 0, -10));
//     }
// }

public class RotateCameraAroundObject : MonoBehaviour
{
    public Transform target; // The object to rotate around
    public float rotationSpeed = 5f;

    void Update()
    {
        // Check if the target is assigned
        if (target == null)
        {
            Debug.LogWarning("target variabelen er ikke der");
            return;
        }
        float horizontalInput = Input.GetAxis("Horizontal");
        float horizontalRotation = horizontalInput * rotationSpeed * Time.deltaTime;
        transform.RotateAround(target.position, Vector3.up, horizontalRotation);
    }
}