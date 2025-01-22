using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareColor : MonoBehaviour
{
    //Reference for the sprite renderer.
    SpriteRenderer m_SpriteRenderer;

    //Gets the sprite renderer component when the scene is started.
    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    //Method that changes the Squares color to black when the spacebar is pressed.
    void ChangeColorBlack()
    {
        m_SpriteRenderer.color = Color.black;
    }
    //Method that changes the Squares color to white when the spacebar stops being pressed.
    void ChangeColorWhite()
    {
        m_SpriteRenderer.color = Color.white;
    }

    //Method for subscribing the color methods to the action.
    void OnEnable()
    {
        Actions.StartInteractEvent += ChangeColorBlack;
        Actions.CanceledInteractEvent += ChangeColorWhite;
    }

    //Method for unsubscribing the color methods from the action.
    void OnDisable()
    {
        Actions.StartInteractEvent -= ChangeColorBlack;
        Actions.CanceledInteractEvent -= ChangeColorWhite;
    }
}
