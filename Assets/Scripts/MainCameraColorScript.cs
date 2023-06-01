using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCameraColorScript : MonoBehaviour
{
    public Color profileSceneColor = new Color(1f, 0.63f, 0.37f);
    public Color deafultColor = new Color(1f, 0.86f, 0.37f);

    private Camera mainCamera;

    private void Awake()
    {
        mainCamera= Camera.main;
    }
    // Start is called before the first frame update
    void Start()
    {
        UpdateCameraColor();
    }

    private void UpdateCameraColor()
    {
        if(SceneManager.GetActiveScene().name == "ProfileScene")
        {
            mainCamera.backgroundColor = profileSceneColor;
        }
        else
        {
            mainCamera.backgroundColor = deafultColor;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
