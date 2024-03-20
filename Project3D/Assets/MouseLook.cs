using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    
    public float mouseSensitivity = 100f; //Gjør at du kan endre muse sensitivitet i denne variabelen her

    void Start()
    {
        
    }

    void Update()
    {
        float mouseX = Input.GetAxis("mouse X") * mouseSensitivity * Time.deltaTime; //Lager variabel som tracker hvor musen er på X aksen, ganger med sensitiviteten for at man kan endre sensen senere, alt som skjer i "void update()" blir gjort en gang per frame så vi ganger med time.deltatime for at ikke folk med høyere fps får advatage eller disadvantage
        float mouseY = Input.GetAxis("mouse Y") * mouseSensitivity * Time.deltaTime; //Det samme som linjen over bare at det er Y aksen til musen den detecter og ikke X aksen
    }
}
