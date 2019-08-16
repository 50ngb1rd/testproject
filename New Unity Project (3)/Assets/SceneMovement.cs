using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MaintoTut()
    {
        SceneManager.LoadScene(1);
    }

    public void TutToGame()
    {
        SceneManager.LoadScene(2);
    }

    public void GameToDHCP()
    {
        SceneManager.LoadScene(3);
    }
    public void DHCPToGAME()
    {
        SceneManager.LoadScene(4);
    }
    public void AlwaysBackToMain()
    {
        SceneManager.LoadScene(0);
    }
}
