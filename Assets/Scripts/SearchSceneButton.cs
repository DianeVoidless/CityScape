using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SearchSceneButton : MonoBehaviour
{
    public void OnButtonClick()
    {
        // Load the new scene here
        SceneManager.LoadScene("SearchScene");
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
