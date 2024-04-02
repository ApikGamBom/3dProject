using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour
{
    
    public float mouseSensitivity = 100f;
    
    public Transform playerBody;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = UnityEngine.Input.GetAxis("MouseX") * mouseSensitivity * Time.deltaTime;
        float mouseY = UnityEngine.Input.GetAxis("MouseY") * mouseSensitivity * Time.deltaTime;

        playerBody.Rotate(Vector3.up * mouseX);
    }
}
