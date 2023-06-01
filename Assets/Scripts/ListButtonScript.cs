using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class ListButtonScript : MonoBehaviour
{
    public Animator squareAnimator; // Reference to the Animator component of the Square element

    private void Start()
    {
        squareAnimator = GameObject.Find("Square").GetComponent<Animator>(); // Find the Square GameObject and get its Animator component
    }

    public void OnButtonClick()
    {
        squareAnimator.Play("FadeIn"); // Trigger the "FadeIn" animation on the Square
    }
}