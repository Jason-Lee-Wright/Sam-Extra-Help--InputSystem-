using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMentEvent : MonoBehaviour
{
    private void OnEnable()
    {
        InputActions.MoveEventStart += moveplayerup;
    }

    private void OnDisable()
    {
        InputActions.MoveEventStart -= moveplayerup;
    }

    void moveplayerup()
    {
        transform.position = Vector2.up;
    }
}
