using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProfileSceneButton : MonoBehaviour
{
    
    public void OnButtonClick()
    {
        // Load the new scene here
        SceneManager.LoadScene("ProfileScene");
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
