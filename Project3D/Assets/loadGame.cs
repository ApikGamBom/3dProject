using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void loadTerrain()
    {
        SceneManager.LoadScene("MainScene");
    }
}
