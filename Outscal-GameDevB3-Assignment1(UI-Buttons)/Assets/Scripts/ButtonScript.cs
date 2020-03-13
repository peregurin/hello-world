using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    //public GameObject button;
    //Button button;
    int sceneIndex;

    private void Start()
    {
        sceneIndex = int.Parse(gameObject.name);
    }

    public void OnButtonClick()
    {
        Debug.Log(gameObject.name);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + sceneIndex);
        //Debug.Log("Button pressed, go to level 01");
    }

    public void GoBack()
    {
        SceneManager.LoadScene(0);
    }

    
}
