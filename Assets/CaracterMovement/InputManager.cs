using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour, GamePlay.IPlayerInputActions
{
    private GamePlay gameplay;

    void Awake()
    {
        gameplay = new GamePlay();

        gameplay.PlayerInput.Enable();

        gameplay.PlayerInput.SetCallbacks(this);


    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        
    }
}


public static class InputActions
{
    public static Action<Vector2> MoveEvent;
}