using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapSceneButton : MonoBehaviour
{
    public void OnButtonClick()
    {
        // Load the new scene here
        SceneManager.LoadScene("MapScene");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
