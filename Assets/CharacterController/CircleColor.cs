using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleColor : MonoBehaviour
{
    //Creating a reference for the Sprite Renderer.
    SpriteRenderer m_SpriteRenderer;

    //Gets the sprite renderer component when the scene is started.
    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    
    //Method that changes the color of the Circle to Yellow once the Spacebar is pressed.
    void ChangeColorCircle()
    {
        m_SpriteRenderer.color = Color.yellow;
    }
    
    //Method that change the Circle to blue once the input is canceled.
    void ChangeColorBlue()
    {
        m_SpriteRenderer.color = Color.blue;
    }


    //Method that subscribes the color methods from the action.
    void OnEnable()
    {
        Actions.StartInteractEvent += ChangeColorCircle;
        Actions.CanceledInteractEvent += ChangeColorBlue;
    }

    //Method that unsubscribes the color methods from the action.
    void OnDisable()
    {
        Actions.StartInteractEvent -= ChangeColorCircle;
        Actions.CanceledInteractEvent -= ChangeColorBlue;
    }
}
