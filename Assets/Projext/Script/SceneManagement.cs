using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour {
    public void StartNewGame()
    {
        SceneManager.LoadScene("Level_01");
    }	
}
