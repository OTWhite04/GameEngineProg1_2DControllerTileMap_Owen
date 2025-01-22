using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleColor : MonoBehaviour
{
    //Reference to the sprite renderer.
    SpriteRenderer m_SpriteRenderer;

    //Gets the sprite renderer component when the scene is started.
    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }

  
    //Method that changes the color of the triangle to green when spacebar is pressed.
    void ChangeColorGreen()
    {
        m_SpriteRenderer.color = Color.green;
    }

    //Method that changes the color of the triangle to cyan when spacebar stops being pressed.
    void ChangeColorCyan()
    {
        m_SpriteRenderer.color = Color.cyan;
    }

    //Method that subscribes the color methods from the action.
    void OnEnable()
    {
        Actions.StartInteractEvent += ChangeColorGreen;
        Actions.CanceledInteractEvent += ChangeColorCyan;
    }

    //Method that unsubscribes the color methods from the action.
    void OnDisable()
    {
        Actions.StartInteractEvent -= ChangeColorGreen;
        Actions.CanceledInteractEvent -= ChangeColorCyan;
    }




}
