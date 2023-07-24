using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public Canvas controls;
    public Canvas meniu;
    public void Scene1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void OnQuit()
    {
        Application.Quit();
    }

    public void Scene12()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void Controale()
    {
        controls.gameObject.SetActive(true);
        meniu.gameObject.SetActive(false);
    }
    public void ControaleInapoi()
    {
        controls.gameObject.SetActive(false);
        meniu.gameObject.SetActive(true);
    }
}
